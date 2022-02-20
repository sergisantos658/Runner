using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    public NextScreen _endscreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("WinTrigger"))
        {
            _endscreen.EndScreen(gameObject);
        }
    }
}
