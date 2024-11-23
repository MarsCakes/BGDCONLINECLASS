using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinObjective : MonoBehaviour
{
    public string playerSide;
    private ScoreManager scoreManager;
    public BallMovement ballMovementScript;

    public void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        Debug.Log(SceneManager.GetActiveScene().name);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (playerSide == "Player 1")
            {
                scoreManager.ChangeScore(1,2);

            }
            else
            {
                scoreManager.ChangeScore(1,1);
            }
            scoreManager.ChangeMapCounter += 1;
            ballMovementScript.ResetPos();
        }
        if (scoreManager.ChangeMapCounter == 5)
        {
            SceneManager.LoadScene("Dark");
        }
    }


}
