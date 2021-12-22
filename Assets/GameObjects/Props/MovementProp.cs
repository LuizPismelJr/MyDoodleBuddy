using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementProp : MonoBehaviour
{
    [Header("Velocity System")]
    [SerializeField] VelocitySystem velocitySystem;

    private void Update()
    {
        MoveTowardsPlayer(velocitySystem.GetVeloValor());
    }

    void MoveTowardsPlayer(float aceleration)
    {
        this.transform.position -= new Vector3(aceleration,0,0);
    }
}
