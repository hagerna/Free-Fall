using UnityEngine;

public class BoostTrigger : MonoBehaviour
{
	void OnTriggerEnter()		//trigger boost when player passes through green ring
	{FindObjectOfType<PlayerMovement>().Boost();}
}
