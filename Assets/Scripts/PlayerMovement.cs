using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    
    private List<Transform> snake = new List<Transform>();

    [SerializeField] private GameObject head;
    [SerializeField] private GameObject midSection;
    [SerializeField] private GameObject tail;
    


    [SerializeField]
    private float rotateSpeed;
    [SerializeField]
    private float minDistance;
   
    Vector3 newDirection;
    [SerializeField] private Transform rightTarget;
    [SerializeField] private Transform leftTarget;

    private float dis;
    private Transform curBodyPart;
    private Transform prevBodyPart;

    private string dir = "Up";

    [SerializeField] private int beginSize;
    void Start()
    {
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
        rb = GetComponent<Rigidbody>();
        snake.Add(head.transform);

        //snake.AddLast(Instantiate(tail));

        for (int i = 0; i < beginSize - 1; i++)
        {
            AddBodyPart();
        }
        
    }

    void Update()
    { 
    
    }
    void FixedUpdate()
    {

        
       
        MoveForward(transform.forward);

        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position. Ommitted if you use list

                //Check if drag distance is greater than 20% of the screen height
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//It's a drag
                 //check if the drag is vertical or horizontal
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   //If the horizontal movement is greater than the vertical movement...
                        if ((lp.x > fp.x))  //If the movement was to the right)
                        {   //Right swipe
                            Debug.Log("Right Swipe");
                            if (dir == "Up" || dir == "Down")
                            {
                                
                                if (dir == "Up")
                                {
                                    newDirection = rightTarget.position - transform.position;
                                }
                                else if (dir == "Down")
                                {
                                    newDirection = leftTarget.position - transform.position;
                                }
                               
                                dir = "Right";
                            }
                            
                        }
                        else
                        {   //Left swipe
                            Debug.Log("Left Swipe");
                            if (dir == "Up" || dir == "Down")
                            {
                                
                                if (dir == "Up")
                                {
                                    newDirection = leftTarget.position - transform.position;
                                }
                                else if (dir == "Down")
                                {
                                    newDirection = rightTarget.position - transform.position;
                                }
                                dir = "Left";
                            }
                            
                        }
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            Debug.Log("Up Swipe");
                            if (dir == "Right" || dir == "Left")
                            {
                                
                                if (dir == "Left")
                                {
                                    newDirection = rightTarget.position - transform.position;
                                }
                                else if (dir == "Right")
                                {
                                    newDirection = leftTarget.position - transform.position;
                                }
                                    
                                dir = "Up";
                            }
                            
                            
                        }
                        else
                        {   //Down swipe
                            Debug.Log("Down Swipe");
                            if (dir == "Right" || dir == "Left")
                            {
                                
                                if (dir == "Left")
                                {
                                    newDirection = leftTarget.position - transform.position;
                                }
                                else if (dir == "Right")
                                {
                                    newDirection = rightTarget.position - transform.position;
                                }
                                
                                dir = "Down";
                            }

                        }
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                    Debug.Log("Tap");
                }
            }
        }


        //rotating the head
        Quaternion rotation = Quaternion.LookRotation(newDirection);
        transform.rotation = rotation;

    }


    private void MoveForward(Vector3 dir)
    {


        rb.velocity = dir * speed * Time.deltaTime;

        for (int i = 1; i < snake.Count; i++)
        {
            curBodyPart = snake[i];
            prevBodyPart = snake[i - 1];

            dis = Vector3.Distance(prevBodyPart.position, curBodyPart.position);

            Vector3 newPos = prevBodyPart.position;

            newPos.y = snake[0].position.y;

            float T = Time.deltaTime * dis / minDistance * rotateSpeed;

            if (T > .5f)
            {
                T = .5f;
            }

            curBodyPart.position = Vector3.Slerp(curBodyPart.position, newPos, T);
            curBodyPart.rotation = Quaternion.Slerp(curBodyPart.rotation, prevBodyPart.rotation, T);
        }

    }

    public void AddBodyPart()
    {
        Transform newPart = (Instantiate(midSection,snake[snake.Count - 1].position, 
            snake[snake.Count - 1].rotation) as GameObject).transform;

        //newPart.SetParent(transform);

        snake.Add(newPart);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            AddBodyPart();
            Destroy(collision.gameObject);
        }
    }
}
