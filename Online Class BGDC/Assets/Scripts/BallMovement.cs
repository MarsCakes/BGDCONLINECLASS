using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of the ball
    private Rigidbody2D rb; // Rigidbody component
    public float speedIncrease;
    public float newVelocityX;
    public float newVelocityY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    public void ResetPos()
    {
        transform.position = new Vector3(0, 0, 0);
        LaunchBall();

    }

    void LaunchBall()
    {
        // Choose a random angle to launch the ball
        float angle = Random.Range(0f, 360f);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
        rb.velocity = direction * speed;
        newVelocityX = rb.velocity.x;
        newVelocityY = rb.velocity.y;
    }

    public void SpeedIncraseOnParry()
    {
        Vector2 newVelocity = rb.velocity.normalized;
        float newSpeed = rb.velocity.magnitude + speedIncrease;
        rb.velocity = newVelocity * newSpeed;
    }
}