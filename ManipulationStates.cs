using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulationStates : MonoBehaviour
{
    private Vector3 moffset;
    private float mZCoord;
    public Material defult;
    public Material hover;
    public Material mouseDown;

    
    void OnMouseOver()
    {
        
        gameObject.GetComponent<Renderer>().material = hover;

    }
     void OnMouseExit()
    {
        
        gameObject.GetComponent<Renderer>().material = defult;

    }
    
    void OnMouseDown()
    { 
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        moffset = gameObject.transform.position - GetMouseWorldPos();
        gameObject.GetComponent<Renderer>().material = mouseDown;
        Debug.Log("clicked");
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + moffset;
    }
}
