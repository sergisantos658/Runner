using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBox : MonoBehaviour
{
    // Start is called before the first frame update
    public Explosion expBox;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other + "AAAAAAAAAAAAAAAAAAA");
        if (Dead.invulnerable == false)
        {
            Debug.Log("fuck the polise");
            expBox.explosion();
            Destroy(gameObject, .1f);
        }
    }
}
