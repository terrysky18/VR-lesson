using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

    private int player_score;
	// Use this for initialization
	void Start () {
        ScoreKeeper old_keeper = FindObjectOfType<ScoreKeeper>();
        player_score = 1;
        if (old_keeper)
        {
            // old keeper is not a null object
            player_score = old_keeper.ShowScore();
            Destroy(old_keeper.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int ShowScore()
    {
        return player_score;
    }
}
