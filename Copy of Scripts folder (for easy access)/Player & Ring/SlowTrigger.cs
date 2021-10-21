using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTrigger : MonoBehaviour
{
	void OnTriggerEnter()		//when passing through red ring, reduce player speed
	{{FindObjectOfType<PlayerMovement>().Slow();}}
}
