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

	public void retry()
	{
		Application.LoadLevel(level);
	}

	public void levelSelect()
	{
		Application.LoadLevel(1);
	}

}
