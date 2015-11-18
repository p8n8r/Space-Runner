using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics2D.gravity = new Vector2 (0, -50);
	}

	public void loadOne()
	{
		Application.LoadLevel(4);
	}

	public void loadTwo()
	{
		Application.LoadLevel(5);
	}

	public void loadThree()
	{
		Application.LoadLevel(6);
	}

	public void loadFour()
	{
		Application.LoadLevel(7);
	}

	public void loadFive()
	{
		Application.LoadLevel(8);
	}

	void OnGUI() {
		
		GUI.Label (new Rect (Screen.width/11, Screen.height/2 + Screen.height/18, 100, 30), "High Score: " + (PlayerPrefs.GetInt("Level4").ToString()));
		GUI.Label (new Rect (Screen.width/11 + 150, Screen.height/2 + Screen.height/18, 100, 30), "High Score: " + (PlayerPrefs.GetInt("Level5").ToString()));
		GUI.Label (new Rect (Screen.width/11 + 300, Screen.height/2 + Screen.height/18, 100, 30), "High Score: " + (PlayerPrefs.GetInt("Level6").ToString()));
		GUI.Label (new Rect (Screen.width/11 + 450, Screen.height/2 + Screen.height/18, 100, 30), "High Score: " + (PlayerPrefs.GetInt("Level5").ToString()));
		GUI.Label (new Rect (Screen.width/11 + 600, Screen.height/2 + Screen.height/18, 100, 30), "High Score: " + (PlayerPrefs.GetInt("Level6").ToString()));
	}

}
