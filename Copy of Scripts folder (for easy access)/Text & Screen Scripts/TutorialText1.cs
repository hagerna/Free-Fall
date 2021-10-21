using UnityEngine;
using UnityEngine.UI;

public class TutorialText1 : MonoBehaviour
{
	public Text tutorial;
	public PlayerMovement movement;
	
	void Start()
	{
	movement.enabled = false;
	First();
	Invoke("Second", 5);
	Invoke("Third", 10);
	Invoke("Fourth", 15);
	Invoke("Fifth", 20);
	}
	
	
	void First()
		{tutorial.text = "Welcome to Free Fall!";}
	void Second()
		{tutorial.text = "Your Goal: To reach the bottom as FAST as possible!";}
	void Third()
		{tutorial.text = "Falling through green rings will give you a boost!";}
	void Fourth()
		{tutorial.text = "While red rings will slow you down!";}
	void Fifth()
		{tutorial.text = "And watch out for obstacles! Hitting one will make you restart!";}
}

