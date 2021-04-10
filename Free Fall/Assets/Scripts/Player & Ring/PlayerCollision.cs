using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement movement;
	public Rigidbody rb;
	private bool collide = true;


    void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle" && collide == true) //collision with obstacle
		{
			movement.enabled = false;
			rb.useGravity = false;
			collide = false;
			FindObjectOfType<GameManager>().Reset();
			FindObjectOfType<FollowPlayer>().stopFollow();
			FindObjectOfType<Upgrades>().impact();
			FindObjectOfType<ScoreTracker>().stopScore();
			FindObjectOfType<Upgrades>().impact();
		}
		
		if (collisionInfo.collider.tag == "LevelEnd" && collide == true) //collision with end goal
		{
			
			movement.enabled = false;
			rb.useGravity = false;
			collide = false;
			FindObjectOfType<GameManager>().NextLevel();
			FindObjectOfType<FollowPlayer>().stopFollow();
		}
	}
}
