using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    public NextScreen _endscreen;
    public AudioSource source;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("WinTrigger"))
        {
            source.Play();
            _endscreen.EndScreen(gameObject);
        }
    }
}
