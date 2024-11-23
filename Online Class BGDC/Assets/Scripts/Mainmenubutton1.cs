using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenubutton : MonoBehaviour
{
    public void MoveToGameplay()
    {
        SceneManager.LoadScene("Default");
    }
}

