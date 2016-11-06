using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour {

    private Text text;

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        float threshold = 3f;
        LeverManager keep_time = FindObjectOfType<LeverManager>();
        float timerScore = keep_time.ShowTimeRemaining();
        if (timerScore < threshold)
        {
            text.text = "" + timerScore;
            text.color = Color.red;
        }
        else
        {
            text.text = "" + timerScore;
        }
	}
}
