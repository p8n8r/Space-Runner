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
}
