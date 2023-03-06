using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Photon.Pun;

public class Foodspawner : MonoBehaviour//PunCallbacks
{
    // Start is called before the first frame update
    public float min_X;
    public float max_X;
    public float min_y;
    public float max_y;
    public float min_z;
    public float max_z;
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public GameObject food4;
    public GameObject food5;
    public float NumOfFood;
    public float MaxNumOfFood = 500;
    public float timer = 0;
    public float MaxWaitTime = 500;
    GameObject[] foodpelets;
    //public Vector3 testposition;
    Vector3 RandomPosition;
    float randnum;
    
    void Start()
    {
        RandomPosition =  new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
      



        for (int i = 0; i < MaxNumOfFood; i++){

            randnum = Random.Range(1, 5);
            if (randnum == 1) { 
                Instantiate(food1, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 2)
            {
                Instantiate(food2, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 3)
            {
                Instantiate(food3, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 4)
            {
                Instantiate(food4, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 5)
            {
                Instantiate(food5, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }

        }



    }
// Update is called once per frame
    void Update()
    {
        RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));



        timer += 2 * Time.deltaTime;
        foodpelets = GameObject.FindGameObjectsWithTag("food");

        if (timer >= MaxWaitTime) {

            timer = 0;
            
            foreach (GameObject food in foodpelets) {

                

                    Destroy(food);

                    NumOfFood -= 1;
                
            
            }

            SpawnFood();
        
        }
    }

    void SpawnFood() {
        for (int i = 0; i < MaxNumOfFood ; i++)
        {

            randnum = Random.Range(1, 5);
            if (randnum == 1)
            {
                Instantiate(food1, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 2)
            {
                Instantiate(food2, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 3)
            {
                Instantiate(food3, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 4)
            {
                Instantiate(food4, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }
            else if (randnum == 5)
            {
                Instantiate(food5, RandomPosition, Quaternion.identity);
                NumOfFood += 1;
                RandomPosition = new Vector3(Random.Range(min_X, max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
            }

        }

        

    }




    }

    
