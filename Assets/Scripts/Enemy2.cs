using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    public override void Move()
    {
        rigid.AddForce(Vector2.left * 50);
    }
}
