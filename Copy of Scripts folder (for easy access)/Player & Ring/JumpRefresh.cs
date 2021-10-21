
using UnityEngine;

public class JumpRefresh : MonoBehaviour
{
	
	void OnTriggerEnter()		//when passing through yellow ring, refresh player's jump
	{
		FindObjectOfType<PlayerMovement>().JumpRefresh();
	}
}
