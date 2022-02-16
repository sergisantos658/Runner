using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetObject;
    public Vector3 offsset;

    public float smoothFactor = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 newPosition = targetObject.transform.position + offsset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

    }
}
