using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Dead : MonoBehaviour
{
    public NextScreen _endscreen;
    static public bool invulnerable = false;
    public Explosion expPlayer;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Containers") && invulnerable == false)
        {
            expPlayer.explosion();
            _endscreen.EndScreen(gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            invulnerable = !invulnerable;

        }
    }
}
