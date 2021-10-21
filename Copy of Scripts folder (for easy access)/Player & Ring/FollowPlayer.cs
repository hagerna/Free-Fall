using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

	public Transform player;
	public Vector3 offset;
	private bool follow = true;

	public void stopFollow ()		//when player impacts obstacle, stop the camera following the player
	{
		follow = false;
		Invoke("resetPosition", 3);
	}
	
    void Update()		//have the camera track the ball that the player controls
    {
    	if (follow)
		{transform.position = player.position + offset;}
    }
}