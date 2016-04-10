using UnityEngine;
using System.Collections;

public class GridMovement : MonoBehaviour {
    Vector3 pos;
    // face - back - right - left
    string facing = "front";
    public float speed = 3.0f;

    void Start() {
        pos = transform.position;
    }

    public string getFacing() {
        return facing;
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.Q) && transform.position == pos) {
            pos += Vector3.left;
            facing = "left";
        }
        if (Input.GetKey(KeyCode.D) && transform.position == pos) {
            pos += Vector3.right;
            facing = "right";
        }
        if (Input.GetKey(KeyCode.Z) && transform.position == pos) {
            pos += Vector3.up;
            facing = "front";
        }
        if (Input.GetKey(KeyCode.S) && transform.position == pos) {
            pos += Vector3.down;
            facing = "back";
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
}
