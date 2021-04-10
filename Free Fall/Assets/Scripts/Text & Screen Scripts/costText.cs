using UnityEngine;
using UnityEngine.UI;

public class costText : MonoBehaviour
{
	public Text upgradeText;
	public bool speed; 
	public bool control; 
	public bool jump;
	public bool greenRing;
	public bool redRing;
	public bool blueRing;

    void Update()
    {
		if(FindObjectOfType<Upgrades>() != null)
		{
        if (speed)
		{
			if (FindObjectOfType<Upgrades>().speedCost == 0)
				upgradeText.text = "Fully Upgraded";
			else
				upgradeText.text = "Upgrade Cost: " + FindObjectOfType<Upgrades>().speedCost;
		}
		if (control)
		{
			if (FindObjectOfType<Upgrades>().controlCost == 0)
				upgradeText.text = "Fully Upgraded";
			else
				upgradeText.text = "Upgrade Cost: " + FindObjectOfType<Upgrades>().controlCost;
		}
		if (jump)
		{
			if (FindObjectOfType<Upgrades>().jumpCost == 0)
				upgradeText.text = "Fully Upgraded";
			else
			upgradeText.text = "Upgrade Cost: " + FindObjectOfType<Upgrades>().jumpCost;
		}
		if (greenRing)
		{
			if (FindObjectOfType<Upgrades>().greenCost == 0)
				upgradeText.text = "Fully Upgraded";
			else
				upgradeText.text = "Upgrade Cost: " + FindObjectOfType<Upgrades>().greenCost;
		}
		if (redRing)
		{
			if (FindObjectOfType<Upgrades>().redCost == 0)
				upgradeText.text = "Fully Upgraded";
			else
				upgradeText.text = "Upgrade Cost: " + FindObjectOfType<Upgrades>().redCost;
		}
		if (blueRing)
		{
			if (FindObjectOfType<Upgrades>().blueCost == 0)
				upgradeText.text = "Fully Upgraded";
			else
				upgradeText.text = "Upgrade Cost: " + FindObjectOfType<Upgrades>().blueCost;
		}
		}
    }
}
