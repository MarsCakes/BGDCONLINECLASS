using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPaddleParry : MonoBehaviour
{
    public BallAnimation ballAnim;
    public BallMovement ballMovement;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ballAnim.playDoubleBounce();
            
            ballMovement.SpeedIncraseOnParry();
        }
    }
}
