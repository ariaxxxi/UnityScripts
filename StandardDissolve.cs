using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardDissolve : MonoBehaviour
{
    float growSpeed = 0.3f;
    float cutout = 0.8f;

    void Start()
    {
     
        gameObject.GetComponent<Renderer>().material.SetFloat("_Cutoff", cutout); 
        enabled = false;
    }

    public void enable()
    {
        enabled = true;
    }


    void Update()
    {
        cutout -= growSpeed * Time.deltaTime;
        gameObject.GetComponent<Renderer>().material.SetFloat("_Cutoff", cutout);    
    }
}
