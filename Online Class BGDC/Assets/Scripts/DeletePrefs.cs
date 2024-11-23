using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefs : MonoBehaviour
{

    public static DeletePrefs instance;
    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }

    public void DeleteScoreSave()
    {
        PlayerPrefs.DeleteKey("scoreP1");
        PlayerPrefs.DeleteKey("scoreP2");
        
    }

    public void DeleteAllSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
