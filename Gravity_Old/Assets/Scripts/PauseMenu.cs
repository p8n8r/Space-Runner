using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	public GameObject PausedUI;
	private bool paused = false;
	
	// Use this for initialization
	void Start () {
		
		PausedUI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		//if (Input.GetButtonDown ("Pause")) 
		if (Input.GetKeyDown(KeyCode.P)) 
			paused = !paused;
		
		if (paused) {
			PausedUI.SetActive (true);
			Time.timeScale = 0;
		} else {
			PausedUI.SetActive (false);
			Time.timeScale = 1;
		}
		
	}
	
	public void Resume() {
		paused = false;
	}
	
	public void Restart() {
		Application.LoadLevel (Application.loadedLevel);
	}

	public void LevelSelect() {
		//Load the level that the level select is on
		Application.LoadLevel (1);
	}

	public void MainMenu() {
		//Load the level that the main menu is on
		Application.LoadLevel (0);
	}
	
	public void Quit() {
		//Doesn't work until game is built and executed
		Application.Quit ();
	}
}
