using UnityEngine;
using System.Collections;

public class BeatLevel : MonoBehaviour {

	int score = 0;
	int level = 0;
	
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		level = PlayerPrefs.GetInt ("Level");
		Physics2D.gravity = new Vector2 (0, -50);
	}
	
	void OnGUI() {
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "You Won!!!");
		
		//GUI.Label (new Rect (Screen.width / 2 - 40, 150, 80, 30), "Score: " + score);
		
		if (GUI.Button (new Rect (Screen.width / 2 - 40, 200, 80, 30), "Retry")) {
			Application.LoadLevel(level);
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Next Level")) {
			Application.LoadLevel(level + 1);
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 45, 400, 90, 30), "Level Select")) {
			Application.LoadLevel(1);
		}
	}
}
