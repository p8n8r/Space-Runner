using UnityEngine;
using System.Collections;

public class FinishLevel : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			PlayerPrefs.SetInt ("Level", Application.loadedLevel );
			Application.LoadLevel(3);
			return;
		}
	}
}
