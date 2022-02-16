using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 7;
    public Rigidbody rb;
    float horizontalImput;
    void FixedUpdate()
    {
        Vector3 ForwardMove = -transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = -transform.right * horizontalImput * speed * Time.fixedDeltaTime;
        rb.velocity =  ForwardMove + horizontalMove;
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");
    }
}
