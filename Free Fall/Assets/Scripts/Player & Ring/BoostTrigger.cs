using UnityEngine;

public class BoostTrigger : MonoBehaviour
{
	void OnTriggerEnter()
	{FindObjectOfType<PlayerMovement>().Boost();}
}
