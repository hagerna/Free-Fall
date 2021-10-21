using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Upgrades : MonoBehaviour
{
	//speed and points tracked for each run
	public float topSpeed;
	public float points = 0;
	public float runPoints = 0;

	//variables that control player movement
	[HideInInspector]
	public float fallForce = 300f;
	[HideInInspector]
	public float sideForce = 25f;
	[HideInInspector]
	public float boostFall = 500f;
	public Vector3 slowFall;
	[HideInInspector]
	public int jumpCount = 1;
	public Vector3 blueScale;
	
	
	//variables that control upgrade costs
	public int speedCost = 100;
	public int controlCost = 200;
	public int jumpCost = 500;
	public int greenCost = 100;
	public int redCost = 200;
	public int blueCost = 500;
	
	public static Upgrades instance;
	
	void Awake () {
		if (instance == null)
			instance = this;
		else
		{
			Destroy(gameObject);
			return;
		}
		
		DontDestroyOnLoad(gameObject);
	}


	public void impact()	//on impact calculate score and top speed
	{
		points = Mathf.Round(runPoints) * 3;
		topSpeed = Mathf.Round(topSpeed);
	}
	
	public void resetUpgrades()		//reset the cost of all upgrades
	{
		speedCost = 100;
		controlCost = 200;
		jumpCost = 500;
		greenCost = 100;
		redCost = 200;
		blueCost = 500;
	}
	
	
	//Upgrade Cost Management
	
	public void purchaseSpeedUpgrade()
	{
		Debug.Log("points: " + points);
		if (points >= speedCost && speedCost != 0) {
			fallForce += 50;
			points -= speedCost;
			speedCost += 100;
			if (speedCost > 400)
				speedCost = 0;
		}
	}
	
	public void purchaseControlUpgrade()
	{
		if (points >= controlCost && controlCost != 0) {
			sideForce += 10;
			points -= controlCost;
			controlCost += 200;
			if (controlCost > 800)
				controlCost = 0;
		}
	}
	
	public void purchaseJumpUpgrade()
	{
		if (points >= jumpCost && jumpCost != 0) {
			jumpCount += 1;
			points -= jumpCost;
			jumpCost += 300;
			if (jumpCost > 1400)
				jumpCost = 0;
		}
	}
	
	public void purchaseGreenUpgrade()
	{
		if (points >= greenCost && greenCost != 0) {
			boostFall += 100;
			points -= greenCost;
			greenCost += 100;
			if (greenCost > 400)
				greenCost = 0;
		}
	}
	
	public void purchaseRedUpgrade() 
	{
		if (points >= redCost && redCost != 0) {
			slowFall.y -= 5;
			points -= controlCost;
			controlCost += 200;
			if (controlCost > 800)
				controlCost = 0;
		}
	}
	
	public void purchaseBlueUpgrade()
	{
		if (points >= blueCost && blueCost != 0) {
			blueScale.x += 2;
			blueScale.y += 2;
			blueScale.z += 2;
			points -= blueCost;
			blueCost += 300;
			if (blueCost > 1400)
				blueCost = 0;
		}
	}	
	
}
