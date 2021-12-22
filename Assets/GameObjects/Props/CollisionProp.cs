using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionProp : MonoBehaviour
{
    [Header("Ponto de renascimento")]
    [SerializeField]GameObject spotToReborn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 9)
        {
            this.transform.position = spotToReborn.transform.position;
        }
    }
}
