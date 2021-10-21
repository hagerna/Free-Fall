using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
	public GameObject TutorialScreen;
	public GameObject LevelScreen;
	
	public void tutorialTrue()
	{
		TutorialScreen.SetActive(true);
	}
	
	public void levelTrue()
	{
		LevelScreen.SetActive(true);
	}

}
