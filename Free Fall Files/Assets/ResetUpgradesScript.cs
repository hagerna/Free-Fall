using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetUpgradesScript : MonoBehaviour
{

	public void Reset()
	{
		FindObjectOfType<GameManager>().resetUpgradeScreen();
	}
}
