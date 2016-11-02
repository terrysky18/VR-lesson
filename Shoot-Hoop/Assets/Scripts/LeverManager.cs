using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LeverManager : MonoBehaviour {

    private float timeTillNextLevel = 5f;

    private int current_index;

	// Use this for initialization
	void Start () {
        // Load scene
        current_index = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextScene();
        }
        timeTillNextLevel -= Time.deltaTime;
        Debug.Log("Time until next level:  " + timeTillNextLevel);
        if(timeTillNextLevel <= 0)
        {
            LoadNextScene();
        }
	}

    public void LoadNextScene()
    {
        // Load currentIndex + 1
        SceneManager.LoadScene(current_index + 1);
    }
}
