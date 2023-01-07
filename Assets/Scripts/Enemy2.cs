using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    private void Start()
    {
        Move();
    }
    private void Move()
    {
        rigid.AddForce(Vector2.left * 50);
    }
}
