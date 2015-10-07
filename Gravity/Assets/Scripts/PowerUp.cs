using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	Hud hud;

	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player") {
			hud = GameObject.Find("Main Camera").GetComponent<Hud>();
			hud.IncreaseScore(10);
			Destroy (this.gameObject);
		}

	}
}
