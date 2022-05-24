using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Hologramhandler : MonoBehaviour
{
    public Audiohandler audiohandler;

    public List<GameObject> UIs;

    public List<GameObject> UIaudios;

    public void Displayimage(int n)
    {
        for (int i = 0; i < UIaudios.Count; i++)
        {
            UIs[i].gameObject.SetActive(false);
            UIaudios[i].gameObject.GetComponent<AudioSource>().Stop();
        }

        UIs[n].SetActive(true);
        UIaudios[n].gameObject.GetComponent<AudioSource>().Play();
        Otheraudio();
    }

    public void Otheraudio()
    {
        for (int i = 0; i < audiohandler.Allaudio.Count; i++)
        {
            audiohandler.Allaudio[i].Stop();
        }
    }
   
}
