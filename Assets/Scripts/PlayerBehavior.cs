using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {
	BoxCollider2D playerCollider;

	// Use this for initialization
	void Start () {
		playerCollider = this.GetComponent<BoxCollider2D> ();
	}

	void OnCollisionEnter2D(Collision2D coll) {
		// Debug.Log("You loose !");
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("You loose !");
	}
}
