using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	[SerializeField] private float m_JumpForce = 600f;
	private Rigidbody2D m_Rigidbody2D;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {

			m_Rigidbody2D = other.attachedRigidbody;

			m_Rigidbody2D.velocity = new Vector2(0, 0);

			if (Physics2D.gravity.y > 0) {
				Physics2D.gravity = new Vector2(Physics2D.gravity.y, 0);
				//m_Rigidbody2D.AddForce(new Vector2(m_JumpForce * -1, 0));
			}
			else if (Physics2D.gravity.y < 0) {
				Physics2D.gravity = new Vector2(Physics2D.gravity.y, 0);
				//m_Rigidbody2D.AddForce(new Vector2(m_JumpForce, 0));
				
			}
			else if (Physics2D.gravity.x > 0) {
				Physics2D.gravity = new Vector2(0, Physics2D.gravity.x * -1);
				//m_Rigidbody2D.AddForce(new Vector2(0, m_JumpForce));
				
			}
			else {
				Physics2D.gravity = new Vector2(0, Physics2D.gravity.x * -1);
				//m_Rigidbody2D.AddForce(new Vector2(0, m_JumpForce * -1));
			}

			Vector3 theScale = other.gameObject.transform.eulerAngles;
			theScale.z -= 90;
			other.gameObject.transform.eulerAngles = theScale;

			Vector3 flip = other.gameObject.transform.localScale;
			flip.x *= -1;
			other.gameObject.transform.localScale = flip;

		}
		
		return;
	}
}
