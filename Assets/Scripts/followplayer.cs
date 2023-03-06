using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

using UnityEngine.UI;

public class followplayer : MonoBehaviour
{
    public Transform target;
    //public GameObject Atarget;
    //[SerializeField] private Vector3 playerpos;
    public float smoothspeed = 0.125f;
    public Vector3 offset;
    public Vector3 HeightPos = new Vector3(0, 3, 11.6700001f);
  

   

   
    void Start()
    {
       

    }

    
    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null) { 

            transform.position = target.position + offset;
        }
       

    }
    
   

   
    
}
