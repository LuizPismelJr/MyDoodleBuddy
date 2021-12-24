using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool isPaused;

    [Header("PausePanel")]
    [SerializeField] GameObject panel;
    
    public void Pause()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
        }else
        {
            Time.timeScale = 1;
            isPaused = false;
            panel.SetActive(isPaused);
        }
    }

    public void PausePanel()
    {
        panel.SetActive(isPaused);
    }

}
