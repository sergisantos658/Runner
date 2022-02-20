using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainmenu;
    public GameObject MenuToGo;

    public static event Action<GameObject> ChangeMenu = delegate { };
   

    public void SendMenu()
    {
        ChangeMenu(MenuToGo);
        mainmenu.SetActive(false);
    }

}


