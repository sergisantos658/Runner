using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Dead : MonoBehaviour
{
    public GameObject explosion;
    public NextScreen _endscreen;
    public AudioSource source;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Containers"))
        {
            source.Play();
            Instantiate(explosion, transform.position, transform.rotation);
            _endscreen.EndScreen(gameObject);
        }
    }
}
