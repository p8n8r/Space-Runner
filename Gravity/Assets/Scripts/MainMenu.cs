using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		Physics2D.gravity = new Vector2 (0, -50);
	}

	public void startGame()
	{
		Application.LoadLevel(1);
	}

}
