using UnityEngine;
using System.Collections;

public class BeatLevel : MonoBehaviour {

	int score = 0;
	int level = 0;
	
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		level = PlayerPrefs.GetInt ("Level");

		if (PlayerPrefs.HasKey("Level" + level.ToString())) {
			if (score > PlayerPrefs.GetInt("Level" + level.ToString()))
				PlayerPrefs.SetInt ("Level" + level.ToString(), score );
		} 
		else {
			PlayerPrefs.SetInt ("Level" + level.ToString(), score );
		}

		Physics2D.gravity = new Vector2 (0, -50);
	}

	public void nextLevel()
	{
		Application.LoadLevel(level + 1);
	}

	public void retry()
	{
		Application.LoadLevel(level);
	}
	
	public void levelSelect()
	{
		Application.LoadLevel(1);
	}

	void OnGUI() {
		
		GUI.Label (new Rect (Screen.width/2 - 35 , Screen.height/2 - Screen.height/10, 100, 30), "Score: " + (int)(score));
		GUI.Label (new Rect (Screen.width/2 - 50 , Screen.height/2 - Screen.height/18, 100, 30), "High Score: " + PlayerPrefs.GetInt("Level" + level.ToString()));

	}
}


