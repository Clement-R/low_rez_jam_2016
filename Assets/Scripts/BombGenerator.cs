using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BombGenerator : MonoBehaviour {
	private float[] positions = {0.5f, 1.5f, 2.5f, 3.5f};
	public GameObject bombPrefab;
	public float fireRate = 0.5F;
	private float nextFire = 0.0F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			this.spawnBomb ();
		}
	}

	void spawnBomb() {
		Vector3 bombDirection = new Vector3();

		List<string> pos = new List<string>();
		pos.Add ("x");
		pos.Add ("y");

		// Choose random positions
		int randInt = Random.Range (0, 2);
		string choosedPos = pos[randInt];

		// Choose random side
		List<float> posOnGrid = new List<float>();
		posOnGrid.Add (4.5f);
		posOnGrid.Add (-4.5f);
		float side = posOnGrid[Random.Range (0, 2)];

		if (choosedPos == "x" && side == 4.5f) {
			bombDirection = Vector3.left;
		} else if (choosedPos == "x" && side == -4.5f) {
			bombDirection = Vector3.right;
		} else if (choosedPos == "y" && side == 4.5f) {
			bombDirection = Vector3.down;
		} else if (choosedPos == "y" && side == -4.5f) {
			bombDirection = Vector3.up;
		}

		// Choose bewteen -1 and 1, choose a position in positions
		List<int> posSide = new List<int>();
		posSide.Add (1);
		posSide.Add (-1);
		float direction = posSide[Random.Range (0, 2)];

		// Choose pos on grid
		float randPos = this.positions[Random.Range (0, this.positions.Length)];

		// Create the vector
		Vector3 finalPos = new Vector3 (0, 0, 0);

		if (choosedPos == "x") {
			finalPos.x = side;
			finalPos.y = randPos * direction;
		} else {
			finalPos.x = randPos * direction;
			finalPos.y = side;
		}

		// Instantiate the bomb prefab at the given position
		GameObject bomb = Instantiate (bombPrefab, finalPos, Quaternion.identity) as GameObject;
		bomb.GetComponent<BombBehavior> ().setDirection (bombDirection);
	}
}
