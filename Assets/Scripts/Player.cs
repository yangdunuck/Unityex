using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    public float bulletSpeed;
    // ������ �� �ѹ� ����
    void Start()
    {
        
    }

    // �ݺ� ����
    void Update()
    {
        Move();
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�Ѿ� ����
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = this.transform.position;
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
        }
    }
    private void Move()
    {
        //WŰ�� ������ ��
        if (Input.GetKey(KeyCode.W))
        {
            //���������� ���� ����
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
