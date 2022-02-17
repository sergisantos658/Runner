using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
	bool pause;

	public GameObject mainPauseMenu;

	List<GameObject> menus = new List<GameObject>();
	
	public static event Action<bool> Dialoginteractuable = delegate { };

	private void OnEnable()
	{
		Button.ChangeMenu += ShowMenu;
		
	}

	private void OnDisable()
	{
		Button.ChangeMenu -= ShowMenu;
	}

	public void ShowMenu(GameObject menu, bool IsPause)
	{
		if (IsPause)
		{
			Time.timeScale = 0;
			pause = true;
			Dialoginteractuable(pause);
			
			
		}

		if (menus.Count - 1 >= 0)
		{
			menus[menus.Count - 1].SetActive(false);
		}

		menus.Add(menu);
		menu.SetActive(true);

	}
	public void HideMenu()
	{
		menus[menus.Count - 1].SetActive(false);
		menus.RemoveAt(menus.Count - 1);
		
		if (menus.Count - 1 >= 0)
		{
			menus[menus.Count - 1].SetActive(true);
		}
		else
        {
			Time.timeScale = 1;
			pause = false;
			Dialoginteractuable(pause);
		}
	}



	public void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if(menus.Count == 0)
            {
				//ShowMenu(mainPauseMenu, true);
				HideMenu();

			}
			else
            {
				HideMenu();
            }
		}
	}
}
