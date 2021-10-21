using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	//UI Elements
	public GameObject TutorialScreen;
	public GameObject LevelScreen;
	public GameObject GameDisplay;
	
	private bool gameEnded = false;
	private float restartDelay = 2f;
	private int level = 4;
	
	
	public void PlayTutorial() //triggered on "Play Tutorial" button of Main Menu
   	{	
		SceneManager.LoadScene(1);
		FindObjectOfType<AudioManager>().Stop("MenuMusic");
		FindObjectOfType<AudioManager>().Play("GameMusic");
	}
	
	public void SkipTutorial() //triggered on "Skip Tutorial" button of Main Menu
	{
		SceneManager.LoadScene(level);
		FindObjectOfType<AudioManager>().Stop("MenuMusic");
		FindObjectOfType<AudioManager>().Play("GameMusic");
	}
	
	public void mainMenu() //triggered on "Main Menu" button
	{
		SceneManager.LoadScene(0);
		FindObjectOfType<AudioManager>().Stop("GameMusic");
		FindObjectOfType<AudioManager>().Play("MenuMusic");
	}
	
	public void startLevel() //play game music and hide upgrade screen
	{
		SceneManager.LoadScene(level);
		FindObjectOfType<AudioManager>().Stop("MenuMusic");
		FindObjectOfType<AudioManager>().Play("GameMusic");
		FindObjectOfType<ShowUpgrades>().hide();	
	}
	
	public void resetUpgradeScreen()
	{
		FindObjectOfType<Upgrades>().resetUpgrades();
		FindObjectOfType<PlayerMovement>().ResetStats();
	}
	
	public void Reset() //triggered on impact of Obstacle
   {
   		if (gameEnded == false)
		{
			gameEnded = true;
			Invoke("Restart", restartDelay);
		}
   }
	
   
   void Restart() //Reseting during tutorial or going to Upgrades
   {
   		FindObjectOfType<AudioManager>().Stop("GameMusic");
   		if (SceneManager.GetActiveScene().buildIndex == 3)
   		{
			SceneManager.LoadScene(3);
			FindObjectOfType<AudioManager>().Play("GameMusic");
		}
		else
		{
			FindObjectOfType<ShowUpgrades>().show();
			FindObjectOfType<AudioManager>().Play("MenuMusic");
		}
		
	}
	
	public void NextLevel() //trigged on impact of LevelEnd
	{
		if (gameEnded == false)
		{
			gameEnded = true;
			Next();
		}
	}
   
   void Next() //Transition to next scene, changing music accordingly as well as UI
   {	
   		FindObjectOfType<AudioManager>().Stop("GameMusic");
		FindObjectOfType<AudioManager>().Stop("MenuMusic");
		if (SceneManager.GetActiveScene().buildIndex < 4)
		{
			if (SceneManager.GetActiveScene().buildIndex == 3)
			{
				FindObjectOfType<AudioManager>().Play("MenuMusic");
				if (GameDisplay != null)
					GameDisplay.SetActive(false);
				if (TutorialScreen != null)
					TutorialScreen.SetActive(true);
			}
			if (SceneManager.GetActiveScene().buildIndex == 2) 
			{
				SceneManager.LoadScene(3);
				FindObjectOfType<AudioManager>().Play("GameMusic");
			}
			if (SceneManager.GetActiveScene().buildIndex == 1)
			{
				SceneManager.LoadScene(2);
				FindObjectOfType<AudioManager>().Play("MenuMusic");
			}
		}
		else
		{
			FindObjectOfType<AudioManager>().Play("MenuMusic");
			level += 1;
			if (GameDisplay != null)
				GameDisplay.SetActive(false);
			if (LevelScreen != null)
				LevelScreen.SetActive(true);
		}
		if (FindObjectOfType<Upgrades>() != null)
			FindObjectOfType<Upgrades>().resetUpgrades();
	}
}