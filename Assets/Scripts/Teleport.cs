using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            gameObject.transform.position = new Vector3(2.72f, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            gameObject.transform.position = new Vector3(-2.72f, transform.position.y, transform.position.z);
        }
    }
}
