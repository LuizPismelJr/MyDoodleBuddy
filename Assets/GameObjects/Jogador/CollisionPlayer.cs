using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    EnergyPlayer energyPlayer;

    [Header("Energy Bar")]
    [SerializeField] SetEnergiBar setEnergyBar;

    private void Awake()
    {
        energyPlayer = GetComponent<EnergyPlayer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 7) 
        {
            energyPlayer.PlayerDied();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8) 
        {
            setEnergyBar.SetEnergy(-1);
        }

        if (collision.gameObject.layer == 10)
        {
            setEnergyBar.SetEnergy(+6);
        }
    }
}
