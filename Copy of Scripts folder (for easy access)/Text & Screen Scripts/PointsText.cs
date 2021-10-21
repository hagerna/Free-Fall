using UnityEngine;
using UnityEngine.UI;

public class PointsText : MonoBehaviour
{
   public Text pointsToSpend;
	
	void Update()
    {
		if(FindObjectOfType<Upgrades>() != null)
		{
        	pointsToSpend.text = "Points To Spend: " + FindObjectOfType<Upgrades>().points;
		}
    }
}
