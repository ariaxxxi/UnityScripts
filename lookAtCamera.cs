using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamera : MonoBehaviour
{
    public Camera m_Camera;
 

    void Update()
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.down,
        m_Camera.transform.rotation * Vector3.up);
    }
}
