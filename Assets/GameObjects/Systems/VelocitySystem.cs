using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocitySystem : MonoBehaviour
{
    [Header("Velocidade inicial")]
    [SerializeField] float veloValor;

    [Header("Acrecimo de velocidade")]
    [SerializeField] float addToVelo;


    float count = 0;
    bool acceleracion = false;
    float origem, maxcount = 9;

    private void Start()
    {
        origem = veloValor + maxcount;
    }

    void Update()
    {
        //CountingToAcelerate();
    }

    void CountingToAcelerate() 
    {
        count += Time.deltaTime;

        if(count >= origem - veloValor) 
        {
            acceleracion = true;
            veloValor -= addToVelo;
            count = 0;
        }
        else 
        {
            acceleracion = false;
        }
    }

    public bool GetAceleracionValor() 
    {
        return acceleracion;
    }

    public float GetVeloValor()
    {
        return veloValor;
    }
}
