using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
	[SerializeField]
	TextMeshProUGUI[] textpoints;
	// Start is called before the first frame update
	private void OnEnable()
	{
		PlayerFollowers.pointsEv += DownHealth;
	}

	private void OnDisable()
	{
		PlayerFollowers.pointsEv -= DownHealth;
	}

	public void DownHealth(int	points)
	{
		for(int i = 0; i < textpoints.Length; i++)
        {
			textpoints[i].text = "Points: " + points;
		}
		
		
	}
}
