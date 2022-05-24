using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenehandler : MonoBehaviour
{
    public static Scenehandler instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
   public void Loadscene(string senename)
    {
        SceneManager.LoadSceneAsync(senename);
    }
}
