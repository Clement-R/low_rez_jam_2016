using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 0.5f;
	private Rigidbody2D rb2d;

	private Animator anim;
	private bool isRunning = false;

	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * speed);
		float yPos = transform.position.y + (Input.GetAxis("Vertical") * speed);
		transform.position = new Vector3 (Mathf.Clamp (xPos, -3.5f, 3.5f), Mathf.Clamp (yPos, -3.5f, 3.5f), 0f);;

		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
			isRunning = true;
		} else {
			isRunning = false;
		}

		anim.SetBool("isRunning", isRunning);
	}
}
