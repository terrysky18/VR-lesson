using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialisation
	void Start () {
        //transform.rotation = Quaternion.identity;
        //camera.transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update () {
        float aboutX = Input.GetAxis("Mouse X");    // rotate about X-axis, horizontal
        float aboutY = Input.GetAxis("Mouse Y");    // rotate about Y-axis, vertical

        // rotate gimbal, horizontal
        transform.localRotation = Quaternion.Euler(0, aboutX, 0) * transform.localRotation;

        Camera camera = GetComponentInChildren<Camera>();
        // rotate camera, vertical
        camera.transform.localRotation = Quaternion.Euler(-aboutY, 0, 0) * camera.transform.localRotation;
    }
}
