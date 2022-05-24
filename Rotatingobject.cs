using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatingobject : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(Vector3.up,30f*Time.deltaTime,Space.World);
    }
}
