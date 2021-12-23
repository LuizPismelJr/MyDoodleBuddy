using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energycolected : MonoBehaviour
{
    [Header("Pivot")]
    [SerializeField] GameObject pivot;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            this.transform.position = new Vector3(pivot.transform.position.x,
                                                 this.transform.position.y,
                                                 this.transform.position.z);
        }
    }
}
