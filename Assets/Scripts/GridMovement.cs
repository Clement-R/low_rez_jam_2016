using UnityEngine;
using System.Collections;

public class GridMovement : MonoBehaviour {

    public float speed = 3.0f;

    private Vector3 pos;
    private Animator anim;
	private bool isRunning = false;

    void Start() {
        pos = transform.position;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.Q) && transform.position == pos) {
            pos += Vector3.left;
        } else if (Input.GetKey(KeyCode.D) && transform.position == pos) {
            pos += Vector3.right;
        } else  if (Input.GetKey(KeyCode.Z) && transform.position == pos) {
            pos += Vector3.up;
        } else  if (Input.GetKey(KeyCode.S) && transform.position == pos) {
            pos += Vector3.down;
        }

		if (transform.position != pos) {
			isRunning = true;
		} else {
			isRunning = false;
		}

		anim.SetBool("isRunning", isRunning);

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
}
