using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 1.0f;
	private Animator anim;
	private bool isRunning = false;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		

		/*
		if (transform.position != pos) {
			isRunning = true;
		} else {
			isRunning = false;
		}

		anim.SetBool("isRunning", isRunning);

		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
		*/
	}
}
