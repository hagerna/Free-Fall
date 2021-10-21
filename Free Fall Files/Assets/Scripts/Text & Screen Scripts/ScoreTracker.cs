using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
	public Transform player;
	public Text scoreText;
	private float yFlip;
	
    // Update is called once per frame
    void Update()
    {
		yFlip = (-player.position.y)/10;
		scoreText.text = yFlip.ToString("0") + " m";
    }

	public void stopScore()
	{
		FindObjectOfType<Upgrades>().runPoints = yFlip;
	}
}

