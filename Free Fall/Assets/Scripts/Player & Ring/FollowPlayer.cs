using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

	public Transform player;
	public Vector3 offset;
	private bool follow = true;
	private Vector3 reset;

	public void stopFollow ()
	{
		follow = false;
		Invoke("resetPosition", 3);
	}
	
    // Update is called once per frame
    void Update()
    {
    	if (follow)
		{transform.position = player.position + offset;}
    }
}