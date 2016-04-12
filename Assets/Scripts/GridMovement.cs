using UnityEngine;
using System.Collections;

public class GridMovement : MonoBehaviour {

    public float speed = 3.0f;

    private Vector3 pos;
    private Animator anim;

    void Start() {
        pos = transform.position;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.Q) && transform.position == pos) {
            pos += Vector3.left;
            anim.SetBool("isRunning", true);
        } else if (Input.GetKey(KeyCode.D) && transform.position == pos) {
            pos += Vector3.right;
            anim.SetBool("isRunning", true);
        } else  if (Input.GetKey(KeyCode.Z) && transform.position == pos) {
            pos += Vector3.up;
            anim.SetBool("isRunning", true);
        } else  if (Input.GetKey(KeyCode.S) && transform.position == pos) {
            pos += Vector3.down;
            anim.SetBool("isRunning", true);
        } else {
            anim.SetBool("isRunning", false);
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
}
