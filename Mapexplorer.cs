using UnityEngine;
//using Firebase.Auth;
//using Firebase.Extensions;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
public class Mapexplorer : MonoBehaviour
{
    public void Fortress_btn(GameObject loader)
    {
        loader.SetActive(true);
        Scenehandler.instance.Loadscene("Fortress");
    }

    public void Forest_btn(GameObject loader)
    {
        loader.SetActive(true);
        //Scenehandler.instance.Loadscene("Forest");
        //SceneManager.LoadScene("Forest", LoadSceneMode.Single);

        StartCoroutine(WaitandLoadForest());
    }

    public void Museum_btn(GameObject loader)
    {
        loader.SetActive(true);
        Scenehandler.instance.Loadscene("Museum");
    }

   
    public void Main_btn(GameObject loader)
    {
        loader.SetActive(true);
        Scenehandler.instance.Loadscene("Main");
    }

    private IEnumerator WaitandLoadForest()
    {
        
        AsyncOperation async = SceneManager.LoadSceneAsync("Forest", LoadSceneMode.Single);
        while(async.progress == 100)
        {
            async.allowSceneActivation = true;
        }
        while (!async.isDone)
        {
            yield return async;
        }
    }


}
