using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Photon.Pun;
using UnityEngine.UI;

public class Spawnplayers : MonoBehaviour//PunCallbacks
{
//     // Start is called before the first frame update
//     public GameObject Blueslime;
//     public GameObject purpleSlime;
//     public GameObject GreenSlime;
//     public GameObject yellowSlime;
//     public GameObject RedSlime;
//     public GameObject syanSlime;
//     GameObject player;
//     public Camera PlayerCamera;
//     GameObject playerprefab2;
//     public float min_X;
//     public float max_X;
//     public float min_y;
//     public float max_y;
//     public float min_z;
//     public float max_z;
//     string skin;
//     
//     void Start ()
//     {
// 
//         skin = PlayerPrefs.GetString("SlimeSkin");
//         Vector3 randomPosition = new Vector3(Random.Range(min_X,max_X), Random.Range(min_y, max_y), Random.Range(min_z, max_z));
// 
//         if (skin == "BlueSlime")
//         {
//             player = PhotonNetwork.Instantiate(Blueslime.name, randomPosition, Quaternion.identity);
//             //player = PhotonNetwork.Instantiate(Blueslime.name, new Vector3(379.700012f, 4.30000019f, 392.399994f), Quaternion.identity, 0);
//         }
//         else if (skin == "RedSlime")
//         {
//              player = PhotonNetwork.Instantiate(RedSlime.name, randomPosition, Quaternion.identity);
//             //player = PhotonNetwork.Instantiate(RedSlime.name, new Vector3(379.700012f, 4.30000019f, 392.399994f), Quaternion.identity, 0);
//         }
//         else if (skin == "GreenSlime")
//         {
//             player = PhotonNetwork.Instantiate(GreenSlime.name, randomPosition, Quaternion.identity);
//             //player = PhotonNetwork.Instantiate(GreenSlime.name, new Vector3(379.700012f, 4.30000019f, 392.399994f), Quaternion.identity, 0);
//         }
//         else if (skin == "PurpleSlime")
//         {
//             player = PhotonNetwork.Instantiate(purpleSlime.name, randomPosition, Quaternion.identity);
//             //player = PhotonNetwork.Instantiate(purpleSlime.name, new Vector3(379.700012f, 4.30000019f, 392.399994f), Quaternion.identity, 0);
//         }
//         else if (skin == "YellowSlime")
//         {
//             player = PhotonNetwork.Instantiate(yellowSlime.name, randomPosition, Quaternion.identity);
//             //player = PhotonNetwork.Instantiate(yellowSlime.name, new Vector3(379.700012f, 4.30000019f, 392.399994f), Quaternion.identity, 0);
//         }
//         else if (skin == "SyanSlime")
//         {
//             player = PhotonNetwork.Instantiate(syanSlime.name, randomPosition, Quaternion.identity);
//             //player = PhotonNetwork.Instantiate(syanSlime.name, new Vector3(379.700012f, 4.30000019f, 392.399994f), Quaternion.identity, 0);
//         }
//         else
//         {
//             player = PhotonNetwork.Instantiate(Blueslime.name, randomPosition, Quaternion.identity);
//             //player = PhotonNetwork.Instantiate(Blueslime.name, new Vector3(379.700012f, 4.30000019f, 392.399994f), Quaternion.identity, 0);
// 
//         }
// 
//         Debug.Log("i have joined the game");
//         GameObject camera = GameObject.FindWithTag("MainCamera");
//         GameObject nametag = GameObject.FindGameObjectWithTag("NameTag");
//         GameTagFollowplayer Nametagscript= nametag.GetComponent<GameTagFollowplayer>();
//         Nametagscript.target = player.transform;
//         CharacterControls controller = player.GetComponent<CharacterControls>();
//         controller.enabled = true;
//         followplayer cam = PlayerCamera.GetComponent<followplayer>();
//         cam.enabled = true;
//         cam.target = player.transform;
// 
//     }


}
