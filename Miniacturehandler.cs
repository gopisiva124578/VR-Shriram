using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Miniacturehandler : MonoBehaviour
{
    public List<AudioSource> Allaudio;
    public List<GameObject> Infopanel;


    private void Start()
    {
        for (int i = 0; i < Allaudio.Count; i++)
        {
            Allaudio[i].Stop();
            Infopanel[i].SetActive(false);
        }
    }

    public void Displayinfo()
    {

    }
}
