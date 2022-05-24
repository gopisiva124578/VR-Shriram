using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;


    public AudioSource audio;
    public GameObject loginUI;
    public GameObject registerUI;
    public GameObject forgotUI;
    public GameObject[] onscreenkeyboard;
    
  

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
      
    }


    public void LoginScreen()
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }


    public void Registerscreen()
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }

    public void Hideforgot()
    {
        loginUI.SetActive(true);
        forgotUI.SetActive(false);
    }
          

    public void Cleardata()
    {
      

        for (int i = 0; i < onscreenkeyboard.Length; i++)
        {
            onscreenkeyboard[i].gameObject.SetActive(false);
        }
    }

    public void showPassword(TMP_InputField inputvalue)
    {     
        inputvalue.contentType = TMP_InputField.ContentType.Standard;
        inputvalue.ForceLabelUpdate();
    }

    public void Hidepassword(TMP_InputField inputvalue)
    {
        inputvalue.contentType = TMP_InputField.ContentType.Password;
        inputvalue.ForceLabelUpdate();
    }

    public void Clicksound()
    {
        audio.Play();
    }
        
}
