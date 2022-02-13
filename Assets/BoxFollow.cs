using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFollow : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        transform.SetParent(other.transform);
        Debug.Log("ahora eres mi padre");
    }

}
