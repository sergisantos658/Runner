using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFollow : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerExit(Collider other)
    {
        transform.SetParent(other.transform);
        Debug.Log("ahora eres mi padre");
    }

    private void Update()
    {
        if(Physics.Raycast (transform.position, transform.TransformDirection (Vector3.right), out RaycastHit hitinfoR,2))
        {
            Debug.Log("Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hitinfoR.distance, Color.red);
        }
        else if(Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.right), out RaycastHit hitinfoL, 2))
        {
            Debug.Log("Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(-Vector3.right) * hitinfoR.distance, Color.red);
        }
        
    }
}
