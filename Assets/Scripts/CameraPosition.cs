using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(-606, 31, 488);
    //public Vector3 targetRotation = new Vector3(0, -98, 0);
    public float delay = 19.0f;
    private float timer = 0.0f;
    private bool hasMoved = false;
    public GameObject playerCapsule;
    public Camera playerCamera;

    void Update() {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if the timer has reached the desired delay and the camera hasn't moved yet
        if (timer >= delay && !hasMoved) {
            // Move the camera to the target position
            playerCapsule.transform.position = targetPosition;
            playerCapsule.gameObject.AddComponent<SC_FPSController>();
            playerCapsule.gameObject.GetComponent<SC_FPSController>().playerCamera = playerCamera;
            // Rotate the camera to the target rotation
            //Camera.main.transform.rotation = new Vector3(0, -98, 0);
            hasMoved = true; // Set the flag to prevent further movement
        }
    }
}


