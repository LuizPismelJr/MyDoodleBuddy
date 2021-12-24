using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DistanceManager : MonoBehaviour
{
    int distance, CountToTen, number = 5;
    string display;
    float externalVelocity;
    bool goingUp;

    [Header("Energy Bar")]
    [SerializeField] SetEnergiBar setEnergyBar;

    [Header("Distance Display Text")]
    [SerializeField] TMP_Text txt_distance;

    private void Awake()
    {
        StartCoroutine(AddDistance());
        display = ("M");
        
    }

    IEnumerator AddDistance()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            CountToTen++;
            if (CountToTen > 9) 
            {
                number++;
                CountToTen = 0;
                goingUp = true;
                setEnergyBar.SetEnergy(-3);
            }
            else 
            {
                goingUp = false;
            }
            distance += number;
            txt_distance.text = distance.ToString() + display;
        }
    }

    public bool KnowingWhenToRun() 
    {
        return goingUp;
    }

}
