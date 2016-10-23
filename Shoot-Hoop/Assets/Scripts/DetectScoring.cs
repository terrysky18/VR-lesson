using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

    public int scorePoint = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter (Collision collision)
    {
        // find object component by type
        ScoreKeeper keep_score = FindObjectOfType<ScoreKeeper>();
        keep_score.IncrementScore(scorePoint);
    }
}
