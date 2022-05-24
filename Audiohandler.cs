using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Audio;

public class Audiohandler : MonoBehaviour
{
    // new script
    public List<AudioSource> Allaudio;
    public Hologramhandler hologramhandler;
    // end
    public void Start()
    {
        Audiostop();
    }

    private void Audiostop()
    {
        for (int i = 0; i < Allaudio.Count; i++)
        {
            Allaudio[i].gameObject.SetActive(false);
            for (int j = 0; j < hologramhandler.UIs.Count; j++)
            {
                hologramhandler.UIs[j].SetActive(false);
                hologramhandler.UIaudios[j].gameObject.GetComponent<AudioSource>().Stop();
                
            }
        }
    }

    public void Audioplay(int n)
    {
        for (int i = 0; i <Allaudio.Count; i++)
        {
            Allaudio[i].Stop();
            Audiostop();
           
        }
         Allaudio[n].gameObject.SetActive(true);
            Allaudio[n].Play();
        
    }
}
