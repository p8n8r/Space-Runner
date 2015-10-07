using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		Physics2D.gravity = new Vector2 (0, -50);
	}


	void OnGUI() {
		
		if (GUI.Button (new Rect (Screen.width/2 - Screen.width/16, Screen.height/2 - Screen.height/16, Screen.width/8, Screen.height/8), "Start Game")) {
			Application.LoadLevel(1);
		}
	}
}
