using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCam : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to control the speed of camera movement.

    private void Update()
    {
        // Calculate the new position for the camera.
        Vector3 newPosition = transform.position + Vector3.right * moveSpeed * Time.deltaTime;

        // Set the camera's new position.
        transform.position = newPosition;
    }
}

