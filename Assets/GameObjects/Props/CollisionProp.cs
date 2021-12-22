using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionProp : MonoBehaviour
{
    [Header("Todos os Pivots")]
    [SerializeField] GameObject[] pivots;

    private void Update()
    {
        PositionCheck();
    }

    void PositionCheck() 
    {
        if(this.transform.position.x <= pivots[1].transform.position.x) 
        {
            this.transform.position = new Vector3 (pivots[0].transform.position.x,
                                                   this.transform.position.y,
                                                   this.transform.position.z);
        }
    }
}
