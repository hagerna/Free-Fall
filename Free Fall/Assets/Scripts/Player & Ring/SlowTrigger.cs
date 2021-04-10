using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTrigger : MonoBehaviour
{
	void OnTriggerEnter()
	{{FindObjectOfType<PlayerMovement>().Slow();}}
}
