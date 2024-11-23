using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int scoreP1;
    public int scoreP2;
    public int ChangeMapCounter;
    private TextMeshProUGUI scoreP1_TMP;
    private TextMeshProUGUI scoreP2_TMP;

    private void Start()
    {
        scoreP1 = PlayerPrefs.GetInt("scoreP1");
        scoreP2 = PlayerPrefs.GetInt("scoreP2");
        scoreP1_TMP = GameObject.Find("ScoreP1_TMP").GetComponent<TextMeshProUGUI>();
        scoreP2_TMP = GameObject.Find("ScoreP2_TMP").GetComponent<TextMeshProUGUI>();
        DisplayScore();
    }


    public void ChangeScore(int increment,int player)
    {
        if(player == 1)
        {
            scoreP1 += increment;
            PlayerPrefs.SetInt("scoreP1", scoreP1);
        } 
        else
        {
            scoreP2 += increment;
            PlayerPrefs.SetInt("scoreP2", scoreP2);
        }
        DisplayScore();
    }

    public void DisplayScore()
    {
        scoreP1_TMP.text = scoreP1.ToString();
        scoreP2_TMP.text = scoreP2.ToString();
    }

}

