using UnityEngine;
using System.Collections;

public class GridMovement : MonoBehaviour {
    Vector3 pos;
    public float speed = 3.0f;

    void Start() {
        pos = transform.position;
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.Q) && transform.position == pos) {
            pos += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D) && transform.position == pos) {
            pos += Vector3.right;
        }
        if (Input.GetKey(KeyCode.Z) && transform.position == pos) {
            pos += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S) && transform.position == pos) {
            pos += Vector3.down;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
}
