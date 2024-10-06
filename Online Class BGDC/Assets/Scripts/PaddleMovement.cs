using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public KeyCode upKey = KeyCode.W; // Key for moving up
    public KeyCode downKey = KeyCode.S; // Key for moving down
    public float speed = 10f; // Speed of the paddle movement
    public float topBound = 4f; // Upper boundary for paddle movement
    public float bottomBound = -4f; // Lower boundary for paddle movement

    void Update()
    {
        // Check for key inputs for paddle movement
        if (Input.GetKey(upKey))
        {
            MovePaddle(Vector2.up);
        }
        if (Input.GetKey(downKey))
        {
            MovePaddle(Vector2.down);
        }
    }

    private void MovePaddle(Vector2 direction)
    {
        // Move the paddle in the specified direction based on speed
        transform.Translate(direction * speed * Time.deltaTime);

        // Clamp the paddle position to stay within bounds
        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, bottomBound, topBound);
        transform.position = position;
    }
}
