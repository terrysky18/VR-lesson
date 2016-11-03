using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LeverManager : MonoBehaviour {
    public float timeTillNextLevel;

    private int current_scene_index;
    private bool auto_progress;
    // Use this for initialization
    void Start () {
        // Load scene
        current_scene_index = SceneManager.GetActiveScene().buildIndex;
        auto_progress = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (auto_progress)
        {
            CycleScenes();
        }
        else
        {
            // only use clock counterdown in game scene
            if (current_scene_index == 1)
            {
                timeTillNextLevel -= Time.deltaTime;
                Debug.Log("current level index:  " + current_scene_index);
                Debug.Log("Time to next scene:  " + timeTillNextLevel);
                if (timeTillNextLevel <= 0)
                {
                    // time is up

                    LoadNextScene();
                }
            }
        }
	}

    void CycleScenes()
    {
        // Cycles through all in the scenes in Build Settings
        // useful debug function
        timeTillNextLevel -= Time.deltaTime;
        // check total number of scenes
        int scene_count = SceneManager.sceneCountInBuildSettings;
        Debug.Log("Auto progress:  " + auto_progress);

        Debug.Log("Time until next level:  " + timeTillNextLevel);
        //Debug.Log("Total scenes in build setting:  " + SceneManager.sceneCountInBuildSettings);

        if (timeTillNextLevel <= 0)
        {
            if (current_scene_index == (scene_count - 1))
            {
                // current scene is the last scene
                // cycle back to first scene
                current_scene_index = -1;
            }
            SceneManager.LoadScene(current_scene_index + 1);
        }
    }

    public void LoadNextScene()
    {
        // Load currentIndex + 1
        SceneManager.LoadScene(current_scene_index + 1);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("02_Game");
    }
}
