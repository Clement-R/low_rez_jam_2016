using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DodgerGameManager : MonoBehaviour {

	int score = 0;
	float baseFireRate = .0f;
	BombGenerator generator;

	void Start() {
		generator = this.GetComponent<BombGenerator> ();
		baseFireRate = generator.getFireRate ();
		InvokeRepeating("incrementScore", 0, 1.0f);
	}

	public void incrementScore() {
		score++;

        GameObject scoreObj = GameObject.FindGameObjectWithTag("Score");
        Text scoreText = scoreObj.GetComponent<Text>();
        scoreText.text = "Score : " + score;

        if (score % 10 == 0) {
			this.updateDifficulty ();
		}
	}

	private void updateDifficulty() {
		Debug.Log (generator.getFireRate());
		generator.setFireRate (baseFireRate - (score / 200.0f));
	}
}
