using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics2D.gravity = new Vector2 (0, -50);
	}
	
	
	void OnGUI() {
		
		if (GUI.Button (new Rect (Screen.width/7 - Screen.width/14, Screen.height/7 - Screen.height/17, Screen.width/8, Screen.height/8), "Level 1")) {
			Application.LoadLevel(4);
		}

		if (GUI.Button (new Rect (2 * Screen.width/7 - Screen.width/14, Screen.height/7 - Screen.height/17, Screen.width/8, Screen.height/8), "Level 2")) {
			Application.LoadLevel(5);
		}
	}
}
