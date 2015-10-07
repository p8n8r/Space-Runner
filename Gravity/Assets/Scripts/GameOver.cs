using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	int score = 0;
	int level = 0;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		level = PlayerPrefs.GetInt ("Level");
		Physics2D.gravity = new Vector2 (0, -50);
	}

	void OnGUI() {
		GUI.Label (new Rect (Screen.width / 2 - 35, Screen.height / 4, 70, 30), "You Lose...");

		//GUI.Label (new Rect (Screen.width / 2 - 40, 150, 80, 30), "Score: " + score);

		if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2, 80, 30), "Retry")) {
			Application.LoadLevel(level);
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 45, Screen.height / 2 + 60 , 90, 30), "Level Select")) {
			Application.LoadLevel(1);
		}
	}

}
