using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	// Use this for initialization
	void Start () {
		Spawner ();
	}

	void Spawner() {
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke ("Spawner", Random.Range (spawnMin, spawnMax));
	}

}
