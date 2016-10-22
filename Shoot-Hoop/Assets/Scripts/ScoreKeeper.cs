
using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    int play_score;
	// Use this for initialization
	void Start () {
        play_score = 0;
        Debug.Log(play_score);
    }
	
	// Update is called once per frame
	void Update () {

	}

    // public function to access by another script
    public void IncrementScore()
    {
        play_score++;
        Debug.Log(play_score);
    }
}
