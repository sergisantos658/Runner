using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Dead : MonoBehaviour
{
    public NextScreen _endscreen;
    static public bool invulnerable = false;
    public Explosion exp;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (invulnerable == false)
        {
            Debug.Log("HI");
            exp.explosion();
            _endscreen.EndScreen(collision.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other + "AAAAAAAAAAAAAAAAAAA");
        if (Dead.invulnerable == false)
        {
            Debug.Log("fuck the polise");
            exp.explosion();
            Destroy(other.gameObject, .1f);
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
