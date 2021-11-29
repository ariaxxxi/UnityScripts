using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Collider coll;
    public GameObject magnifier;

    void Start()
    {
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (coll.Raycast(ray, out hit, 1000f))
            {
                
                magnifier.transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z - 0.2f);
                // magnifier.transform.position.z -= 10;
            }
        
    }
}
