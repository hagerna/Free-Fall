using UnityEngine;
using UnityEngine.UI;

public class TopSpeedText : MonoBehaviour
{
    public Text TopSpeed;
	
	void Update()
    {
		if(FindObjectOfType<Upgrades>() != null)
		{
        	TopSpeed.text = "Top Speed: " + FindObjectOfType<Upgrades>().topSpeed + " m/s";
		}
    }
}
