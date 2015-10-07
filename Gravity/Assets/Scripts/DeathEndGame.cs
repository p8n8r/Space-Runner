using UnityEngine;
using System.Collections;

public class DeathEndGame : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			PlayerPrefs.SetInt ("Level", Application.loadedLevel );
			Application.LoadLevel(2);
			return;
		}
	}
}
