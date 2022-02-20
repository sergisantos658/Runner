using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFollow : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float numofRays = 17;
    public float speed = 4;
    public int randomNum = 0;
    public Transform follow;
    public bool colision = false;

    public bool isFollowing => follow != null;

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("HOLA");

        if (other.CompareTag("Player") && !isFollowing)
        {

            randomNum = Random.Range(0, 2);
            //transform.SetParent(other.transform);
            PlayerFollowers.current.AddFollower(transform);
            colision = true;
            
            
        }

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

        if(follow != null)
        {

            if(colision == true)
            {
                transform.localPosition = Vector3.Slerp(transform.localPosition, follow.position, (speed + randomNum) * Time.deltaTime);
                transform.rotation = follow.rotation;
            }

        }

        
    }
}
