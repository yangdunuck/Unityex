using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    public float bulletSpeed;
    // 시작할 떄 한번 실행
    void Start()
    {
        
    }

    // 반복 실행
    void Update()
    {
        Move();
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //총알 생성
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = this.transform.position;
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
        }
    }
    private void Move()
    {
        //W키를 눌렀을 떄
        if (Input.GetKey(KeyCode.W))
        {
            //윗방향으로 벡터 더함
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
