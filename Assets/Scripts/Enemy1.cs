using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    public override void Move()
    {
        rigid.AddForce(Vector2.right * 50);
    }
}
