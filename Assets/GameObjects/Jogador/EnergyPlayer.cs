using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPlayer : MonoBehaviour
{
    [Header("Pause Game")]
    [SerializeField]PauseGame pauseGame;

    [Header("Canvas")]
    [SerializeField] GameObject canvasControles, canvasDeath;

    [Header("Energy Bar")]
    [SerializeField] SetEnergiBar setEnergyBar;

    private void Update()
    {
        EnergyIsEmpity();
    }

    void EnergyIsEmpity()
    {
        if(setEnergyBar.slider.value < 1) 
        {
            PlayerDied();
        }
    }

    public void PlayerDied()
    {
        pauseGame.Pause();
        canvasControles.SetActive(false);
        canvasDeath.SetActive(true);
    }
}
