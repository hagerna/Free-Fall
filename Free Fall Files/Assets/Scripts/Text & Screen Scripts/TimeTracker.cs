using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeTracker : MonoBehaviour
{
	public Text scoreText;
	
    void Update()
    {
		scoreText.text = Time.timeSinceLevelLoad.ToString("0") + " sec";
    }
}
