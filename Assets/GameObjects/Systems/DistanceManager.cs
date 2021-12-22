using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DistanceManager : MonoBehaviour
{
    int distance;
    string display;
    float externalVelocity;

    [Header("Distance Display Text")]
    [SerializeField] TMP_Text txt_distance;

    [Header("Velocity System")]
    [SerializeField] VelocitySystem velocitySystem;


    private void Awake()
    {
        StartCoroutine(AddDistance());
        display = ("M");
        externalVelocity = velocitySystem.GetVeloValor();
    }

    IEnumerator AddDistance()
    {
        while (true)
        {
            VelocityChange();
            yield return new WaitForSeconds(externalVelocity);
            Debug.Log("external" + externalVelocity);
            distance++;
            txt_distance.text = distance.ToString() + display;
        }
    }

    void VelocityChange() 
    {
        bool itChange = velocitySystem.GetAceleracionValor();
        if (itChange) 
        {
            externalVelocity = velocitySystem.GetVeloValor();
        }
    }

}
