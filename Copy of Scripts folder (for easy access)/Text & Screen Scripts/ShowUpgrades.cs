using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUpgrades : MonoBehaviour
{
 
 public GameObject screen;
 public static ShowUpgrades instance;
	
	void Awake () {
		if (instance == null)
			instance = this;
		else
		{
			Destroy(gameObject);
			return;
		}
		
		DontDestroyOnLoad(gameObject);
		hide();
	}
	
	public void show()
	{
		screen.SetActive(true);
	}
	
	public void hide()
	{
		screen.SetActive(false);
	}
}
