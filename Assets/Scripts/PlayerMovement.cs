using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    void Start()
    {
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        

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
                            MoveForward(transform.right);
                        }
                        else
                        {   //Left swipe
                            Debug.Log("Left Swipe");
                            MoveForward(-transform.right);
                        }
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            Debug.Log("Up Swipe");
                            MoveForward(transform.forward);
                        }
                        else
                        {   //Down swipe
                            Debug.Log("Down Swipe");
                            MoveForward(-transform.forward);
                        }
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                    Debug.Log("Tap");
                }
            }
        }



        //PC Movement
        if (Input.GetKeyUp(KeyCode.W))
        {
            MoveForward(transform.forward); 
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            MoveForward(-transform.forward);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            MoveForward(-transform.right);

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            MoveForward(transform.right);
        }

    }


    private void MoveForward(Vector3 dir)
    {


        rb.velocity = dir * speed * Time.deltaTime;

    }

}
