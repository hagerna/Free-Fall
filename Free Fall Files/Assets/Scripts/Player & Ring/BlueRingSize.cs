
using UnityEngine;

public class BlueRingSize : MonoBehaviour
{
	
	public Transform blueRing;
	
	void Awake ()
	{
		if (FindObjectOfType<Upgrades>() == null)
			return;
		else
		{
			blueRing.localScale = FindObjectOfType<Upgrades>().blueScale;		//Adjust the size of blue ring for upgrade
		}
	}
}
