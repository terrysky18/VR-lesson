using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public GameObject ballPrefab;
    private float ballSpeed;

    // Use this for initialization
    void Start () {
        ballSpeed = 810f;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            // instantiate a new ball as an instance
            GameObject instance = Instantiate(ballPrefab);

            // fix new ball instance to camera position
            instance.transform.position = transform.position;
            
            // fix new ball instance direction to camera direction
            Rigidbody rBody = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            float ball_speed = ballSpeed * Time.deltaTime;
            rBody.velocity = camera.transform.rotation * Vector3.forward * ball_speed;
        }
    }
}
