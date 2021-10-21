using UnityEngine;
using UnityEngine.UI;

public class TutorialText2 : MonoBehaviour
{
	public Text tutorial;
	public PlayerMovement movement;
	
	void Start()
	{
	movement.enabled = true;
	First();
	Invoke("Second", 5);
	Invoke("Third", 10);
	Invoke("Fourth", 15);
	Invoke("Fifth", 20);
	}
	
	
	void First()
		{tutorial.text = "Now try using WASD to move!";}
	void Second()
		{tutorial.text = "You can also press SPACE to slow you down for easier control!";}
	void Third()
		{tutorial.text = "To start off you only have one use, but you can buy more through Upgrades!";}
	void Fourth()
		{tutorial.text = "Yellow Rings will refresh your jump!";}
	void Fifth()
		{tutorial.text = "Fall through the Blue Ring to complete the level!";}
}

