using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    //public VMManager vmManager;

    public string exitToScene; 

 
    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Player")
        //{

        //    //Scenehandler.instance.Loadscene(backscene);
        //    vmManager.LeaveRoomAndLoadHomeScene();
        //    Debug.Log("Player Exited");

        //}
        if(other.gameObject.name == "XR Rig" || other.gameObject.tag == "Player")
        {
            Scenehandler.instance.Loadscene(exitToScene);
            Debug.Log("Player trying to Exit!");
        }
    }
}
