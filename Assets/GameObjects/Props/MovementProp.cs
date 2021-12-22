using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementProp : MonoBehaviour
{
    [Header("Velocity System")]
    [SerializeField] VelocitySystem velocitySystem;

    [Header("Todos os Pivots")]
    [SerializeField] GameObject[] pivots;

    int currentPivot;

    [Header("velocidade")]
    [SerializeField] float speed;

    private void Update()
    {
        MoveTowardsPivot();
    }

    void MoveTowardsPivot()
    {
        if (this.transform.position.x > pivots[1].transform.position.x)
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime,0,0);
        }
    }

}
