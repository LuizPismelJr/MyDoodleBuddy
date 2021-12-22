using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementProp : MonoBehaviour
{
    [Header("Velocity System")]
    [SerializeField] VelocitySystem velocitySystem;

    [Header("Pivots")]
    [SerializeField] GameObject[] pivot;

    [Header("velocidade")]
    [SerializeField] float speed;

    private void Update()
    {
        MoveTowardsPivot();
    }

    void MoveTowardsPivot()
    {
        if (this.transform.position.x > pivot[1].transform.position.x) 
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }
}
