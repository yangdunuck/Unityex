using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    private void Start()
    {
        Move();
    }
    private void Move()
    {
        rigid.AddForce(Vector2.right * 50);
    }
}
