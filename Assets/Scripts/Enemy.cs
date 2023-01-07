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
    //Ʈ���ſ� ���� ��
    void OnTriggerEnter2D(Collider2D collision)
    {
        //collision == �浹�� ��ü
        //collision�� �±װ� PlayerBullet�̶��
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            OnDamage(10);
            Destroy(collision.gameObject);
        }
    }
}
