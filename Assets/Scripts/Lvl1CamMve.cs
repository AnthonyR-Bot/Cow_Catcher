using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1CamMve : MonoBehaviour
{
    public float moveSpeed = 15f;

    void Update()
    {
        // Get input from the keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // Move the camera
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
