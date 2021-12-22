using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{

    public void StartGame()
    {
        ChangeScene("RunningScene");
    }

    public void BackToMenu()
    {
        ChangeScene("Menu");
    }

    void ChangeScene(string current)
    {
        SceneManager.LoadScene(current, LoadSceneMode.Single);
    }
}
