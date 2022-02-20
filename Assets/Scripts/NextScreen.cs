using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject endScreen;
    public void EndScreen(GameObject dead)
    {
        endScreen.SetActive(true);
        dead.SetActive(false);
        
    }
}
