using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement movement;
	public Rigidbody rb;
	private bool collide = true;


    void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle" && collide == true) // on collision with obstacle...
		{
			movement.enabled = false;		//stop player controls
			rb.useGravity = false;			//allow ball to bounce in any direction after impact
			collide = false;				//prevent this function triggering multiple times
			FindObjectOfType<GameManager>().Reset();
			FindObjectOfType<FollowPlayer>().stopFollow();
			FindObjectOfType<Upgrades>().impact();
			FindObjectOfType<ScoreTracker>().stopScore();
			FindObjectOfType<Upgrades>().impact();
		}
		
		if (collisionInfo.collider.tag == "LevelEnd" && collide == true) //collision with end goal
		{

			movement.enabled = false;       //stop player controls
			rb.useGravity = false;          //allow ball to bounce in any direction after impact
			collide = false;                //prevent this function triggering multiple times
			FindObjectOfType<GameManager>().NextLevel();
			FindObjectOfType<FollowPlayer>().stopFollow();
		}
	}
}
