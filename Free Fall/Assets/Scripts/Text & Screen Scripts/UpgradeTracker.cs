using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeTracker : MonoBehaviour
{
   public bool speed;
   public bool control;
   public bool jump;
   public bool green;
   public bool red;
   public bool blue;
   
   public Texture[] images;
   public RawImage cellImage;
   private int cellNumber = 1;
   
   public void Upgrade()
   {
   		if (speed)
			{FindObjectOfType<Upgrades>().purchaseSpeedUpgrade();
			cellNumber = FindObjectOfType<Upgrades>().speedCost / 100;}
		if (control)
			{FindObjectOfType<Upgrades>().purchaseControlUpgrade();
			cellNumber = FindObjectOfType<Upgrades>().controlCost / 200;}
		if (jump)
			{FindObjectOfType<Upgrades>().purchaseJumpUpgrade();
			cellNumber = (FindObjectOfType<Upgrades>().jumpCost - 200) / 300;}
		if (green)
			{FindObjectOfType<Upgrades>().purchaseGreenUpgrade();
			cellNumber = FindObjectOfType<Upgrades>().greenCost / 100;}
		if (red)
			{FindObjectOfType<Upgrades>().purchaseRedUpgrade();
			cellNumber = FindObjectOfType<Upgrades>().controlCost / 200;}
		if (blue)
			{FindObjectOfType<Upgrades>().purchaseBlueUpgrade();
			cellNumber = (FindObjectOfType<Upgrades>().blueCost - 200) / 300;}
		cellImage.texture = images[cellNumber];
			
   }
   
   public void FreeFall()
   {
   		FindObjectOfType<GameManager>().startLevel();
   }
   
   public void MainMenu()
   {
   		FindObjectOfType<GameManager>().mainMenu();
   }
   
   public void resetCells()
   {
   		cellNumber = 1;
   		cellImage.texture = images[cellNumber];
   }
   
}



