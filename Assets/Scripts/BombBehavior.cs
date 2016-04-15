using UnityEngine;
using System.Collections;

public class BombBehavior : MonoBehaviour {

	public float speed = 1.0f;
	public float destroyTime = 45;
	private Vector3 direction = Vector3.down;

	// Use this for initialization
	void Start () {
		Destroy(this.gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(this.direction * Time.deltaTime * speed);
	}

	public void setDirection(Vector3 direction) {
		this.direction = direction;
	}

	void OnBecameInvisible() {
		Debug.Log ("Destroyed");
	}
}
