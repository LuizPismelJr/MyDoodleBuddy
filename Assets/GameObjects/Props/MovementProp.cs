using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementProp : MonoBehaviour
{
    [Header("Pivots")]
    [SerializeField] GameObject[] pivot;

    [Header("velocidade")]
    [SerializeField] float speed;

    [Header("DistanceManager")]
    [SerializeField] DistanceManager distanceManager;

    private void Update()
    {
        MoveTowardsPivot();
        SpeedGoesUp();
    }

    private void SpeedGoesUp() 
    {
        if (distanceManager.KnowingWhenToRun()) 
        {
            speed += 0.05f;
        }
    }

    void MoveTowardsPivot()
    {
        if (this.transform.position.x > pivot[1].transform.position.x) 
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }
}
