using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;

	void Update () {

		if (Mathf.Abs(transform.position.x - player.position.x) > 6) {
			if (transform.position.x < player.position.x)
				transform.position = new Vector3(player.position.x - 6, transform.position.y, transform.position.z);
			else
				transform.position = new Vector3(player.position.x + 6, transform.position.y, transform.position.z);
		}
		if (Mathf.Abs (transform.position.y - player.position.y) > 3) {
			if (transform.position.y < player.position.y)
				transform.position = new Vector3 (transform.position.x, player.position.y - 3, transform.position.z);
			else
				transform.position = new Vector3 (transform.position.x, player.position.y + 3, transform.position.z);
		}

	}

	void OnGUI() {
		
		if (GUI.Button (new Rect (Screen.width * 15 / 16, 1, Screen.width/16, Screen.height/16), "Pause")) {
			if (Time.timeScale == 0)
				Time.timeScale = 1;
			else 
				Time.timeScale = 0;
		}

		if (Time.timeScale == 0) {
			if (GUI.Button (new Rect (Screen.width/2 - Screen.width/16, Screen.height/2 - Screen.height/10, Screen.width/8, Screen.height/8), "Resume")) {
				Time.timeScale = 1;
			}

			if (GUI.Button (new Rect (Screen.width/2 - Screen.width/16, Screen.height/2 + Screen.height/10, Screen.width/8, Screen.height/8), "Quit")) {
				Application.LoadLevel(1);
			}
		}
	}
}
