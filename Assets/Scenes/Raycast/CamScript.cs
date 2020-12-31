using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CamScript : MonoBehaviour
{
    public LayerMask layerMask;
    public float rayLength;
    public GameObject cube;
    public Camera cam;
    Vector3 pos = new Vector3(10, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                
                if(hit.collider.name == "Plane")
                {
                    Debug.Log(transform.forward);
                    cube.transform.position = hit.point + new Vector3(0,cube.transform.localScale.y / 2,0);
                    
                    
                }
                
            }
        }
    }
}
