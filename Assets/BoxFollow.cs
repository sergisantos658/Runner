using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFollow : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float numofRays = 17;
    public float speed = 4;
    public int randomNum = 0;
    public GameObject follow;
    public bool colision = false;
    private void OnTriggerExit(Collider other)
    {
        randomNum = Random.Range(0, 2);
        //transform.SetParent(other.transform);
        PlayerFollowers.current.AddFollower(gameObject);
        colision = true;
        
    }



    private void Update()
    {
        /*if(Physics.Raycast (transform.position, transform.TransformDirection (Vector3.right), out RaycastHit hitinfoR,2))
        {
            //Debug.Log("Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hitinfoR.distance, Color.red);
        }
        else if(Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.right), out RaycastHit hitinfoL, 2))
        {
            //Debug.Log("Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(-Vector3.right) * hitinfoR.distance, Color.red);
        }*/
        /*for (int i = 0; i < numofRays; i++)
        {
            float dist =
        }*/
        if(colision == true)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, follow.transform.position, (speed + randomNum) * Time.deltaTime);
            transform.rotation = follow.transform.rotation;
        }


        
        
    }
}
