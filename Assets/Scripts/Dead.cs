using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject explosion;
    public NextScreen _endscreen;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Containers"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            _endscreen.EndScreen(gameObject);
        }
    }
}
