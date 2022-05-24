using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Firebase.Auth;
//using Firebase.Extensions;

public class Main : MonoBehaviour
{
    private bool ison;
    private void Start()
    {
        print(PlayerPrefs.GetString("Username"));
    }
    public void Servicedesk_btn(GameObject loader)
    {
        loader.SetActive(true);
        Scenehandler.instance.Loadscene("ServiceDesk");
    }

    public void Mapexplorer_btn(GameObject loader)
    {
        loader.SetActive(true);
        Scenehandler.instance.Loadscene("MapExplorer");
    }

    public void Networkingsuite_btn(GameObject loader)
    {
        loader.SetActive(true);
        Scenehandler.instance.Loadscene("PlayerSelection");
    }

    public void Btn_toggle(GameObject obj)
    {
        ison = !ison;
        if (ison)
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
        
    }


    public void OnTriggerEnter(Collider other)
    {

        //if (other.gameObject.name == "XR Rig")
        //{
        //    FirebaseAuth.DefaultInstance.SignOut();
        //    PlayerPrefs.SetString("User", "Usernotavailable");
        //    PlayerPrefs.DeleteAll();
        //}

        if (other.gameObject.name == "XR Rig")
        {// update database
            PlayerPrefs.DeleteAll();
          //  FirebaseAuth.DefaultInstance.SignOut();
            PlayerPrefs.SetString("User", "Usernotavailable");
         //   Getpost.online = false;
         //   Getpost.instance.UpdateDatabase(true, Getpost.idToken);          

        }

    }
}
