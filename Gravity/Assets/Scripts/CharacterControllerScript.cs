using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {

	public float maxSpeed = 10;
	private bool facingRight = true;
	private Rigidbody2D character;

	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = .2f;
	public LayerMask whatIsGround;

	void Awake() {
		character = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		character.velocity = new Vector2 (move * maxSpeed, character.velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip (); 
					
	}

	void update() {


	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale; 
	}
}
