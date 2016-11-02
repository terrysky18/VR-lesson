using UnityEngine;
using System.Collections;

/*
 * The script is developmental
 * NO LONGER IN USE
 * it's kept as an example
 */

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float ball_speed = 400f * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rBody = instance.GetComponent<Rigidbody>();
            rBody.velocity = Vector3.left * ball_speed;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ballPrefab);
            // fix new ball instance to camera position
            instance.transform.position = transform.position;
            Rigidbody rBody = instance.GetComponent<Rigidbody>();
            rBody.velocity = Vector3.forward * ball_speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rBody = instance.GetComponent<Rigidbody>();
            rBody.velocity = Vector3.right * ball_speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rBody = instance.GetComponent<Rigidbody>();
            rBody.velocity = Vector3.back * ball_speed;
        }
    }
}
