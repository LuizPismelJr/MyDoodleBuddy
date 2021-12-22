using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    Rigidbody2D rigid;

    [Header("Jumping Impulse")]
    [SerializeField] float impulse;

    [Header("PlayerPosition")]
    [SerializeField] GameObject playerPosition;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveBackToWhereBelong();
    }

    public void Jumping() 
    {
            rigid.AddForce(transform.up * impulse);
    }

    void MoveBackToWhereBelong() 
    {
        Vector3 where = new Vector3(playerPosition.transform.position.x,
                                    transform.position.y,
                                    transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, where, 0.04f * Time.deltaTime);
    }

}
