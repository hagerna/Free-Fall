
using UnityEngine;

public class JumpRefresh : MonoBehaviour
{
	
	void OnTriggerEnter()
	{
		FindObjectOfType<PlayerMovement>().JumpRefresh();
	}
}
