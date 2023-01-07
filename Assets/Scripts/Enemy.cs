using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody2D rigid;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    public int hp = 50;
    public void OnDamage(int DMG)
    {
        hp -= DMG;
        Debug.Log(hp);
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    //트리거에 들어갔을 때
    void OnTriggerEnter2D(Collider2D collision)
    {
        //collision == 충돌한 물체
        //collision의 태그가 PlayerBullet이라면
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            OnDamage(10);
            Destroy(collision.gameObject);
        }
    }
}
