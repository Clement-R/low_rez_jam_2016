using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("You loose !");
	}
}
