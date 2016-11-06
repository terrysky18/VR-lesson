
using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    int play_score;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        // play_score = 0;
        //Debug.Log(play_score);
    }
	
	// Update is called once per frame
	void Update () {

	}

    // public function to access by another script
    public void IncrementScore(int amount)
    {
        play_score += amount;
        //Debug.Log(play_score);
    }

    public int ShowScore()
    {
        return play_score;
    }
}
