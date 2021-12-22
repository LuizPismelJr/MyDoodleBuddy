using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPlayer : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] GameObject controlCanvas, deathCanvas;

    [Header("PauseGame")]
    [SerializeField] PauseGame pauseGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDied()
    {
        pauseGame.Pause();
        controlCanvas.SetActive(false);
        deathCanvas.SetActive(true);
    }
}
