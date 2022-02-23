using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    public GameObject explosionGO;
    public void explosion()
    {
        source.Play();
        Instantiate(explosionGO, transform.position, transform.rotation);
    }
}
