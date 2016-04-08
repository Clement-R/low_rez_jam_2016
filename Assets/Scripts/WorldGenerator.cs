using UnityEngine;
using System.Collections;

public class WorldGenerator : MonoBehaviour {
    public GameObject[] floorTiles;
    public int[][] level;
    

    // Use this for initialization
    void Start () {
        level = new int[][] {
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }
        };

        this.createLevel();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void createLevel () {
        for (int i = 0; i < level.Length; i++) {
            int[] row = level[i];

            for (int j = 0; j < row.Length; j++) {
                int tile = row[j];

                GameObject toInstantiate;

                switch (tile) {
                    case 1:
                        toInstantiate = floorTiles[0] as GameObject;
                        break;
                    default:
                        toInstantiate = null;
                        break;
                }

                float x = j - 3.5f;
                float y = (level.Length - 1) - i - 3.5f;

                GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                // instance.transform.SetParent(boardHolder);
                // Quaternion.AngleAxis(90.0f, new Vector3(0, 0, 1));
            }
        }
    }
}
