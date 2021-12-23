using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPlayer : MonoBehaviour
{
    [Header("Pause Game")]
    [SerializeField]PauseGame pauseGame;

    [Header("Canvas")]
    [SerializeField] GameObject canvasControles, canvasDeath;

    public void PlayerDied()
    {
        pauseGame.Pause();
        canvasControles.SetActive(false);
        canvasDeath.SetActive(true);
    }
}
