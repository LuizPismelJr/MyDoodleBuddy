using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionProp : MonoBehaviour
{
    [Header("Pivots")]
    [SerializeField] GameObject[] pivot;

    private void Update()
    {
        PivotRestartPosition();
    }

    public void PivotRestartPosition() 
    {
        if (this.transform.position.x > pivot[1].transform.position.x) 
        {
            this.transform.position = new Vector3(pivot[0].transform.position.x,
                                                  this.transform.position.y,
                                                  this.transform.position.z);

        }
    }


}
