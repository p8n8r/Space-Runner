using UnityEngine;
using System.Collections;

public class Oscillate : MonoBehaviour {

	[SerializeField] private float speed = 100;
	[SerializeField] private float radius = 1;
	[SerializeField] private bool leftRight = true;
	private Rigidbody2D m_Rigidbody2D;
	private Vector2 originalPosition;

	// Use this for initialization
	void Start () {
		m_Rigidbody2D = GetComponent<Rigidbody2D> ();
		if (leftRight)
			m_Rigidbody2D.AddForce(new Vector2(speed, 0));
		else 
			m_Rigidbody2D.AddForce(new Vector2(0, speed));


		originalPosition = m_Rigidbody2D.position;
			                       	                    
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float dis = Vector2.Distance (m_Rigidbody2D.position, originalPosition);

		if (Mathf.Abs (dis) > radius) {
			speed = speed * -1;
			m_Rigidbody2D.velocity = new Vector2(0, 0);

			if (leftRight)
				m_Rigidbody2D.AddForce(new Vector2(speed, 0));
			else 
				m_Rigidbody2D.AddForce(new Vector2(0, speed));
		}



		
		
		
	}
}
