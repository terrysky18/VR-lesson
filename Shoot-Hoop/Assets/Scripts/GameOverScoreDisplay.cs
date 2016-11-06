using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

    Text score_text;

	// Use this for initialization
	void Start () {
        score_text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        ScoreAbsorber play_score = FindObjectOfType<ScoreAbsorber>();
        int the_score = play_score.ShowScore();
        score_text.text = "SCoRE:  " + the_score;
	}
}
