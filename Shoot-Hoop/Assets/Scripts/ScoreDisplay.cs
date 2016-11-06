using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        ScoreKeeper keep_score = FindObjectOfType<ScoreKeeper>();
        int playerScore = keep_score.ShowScore();
        text.text = "Score:  " + playerScore;
	}
}
