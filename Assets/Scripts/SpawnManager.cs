using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy1_prefab;
    public GameObject enemy2_prefab;
    void Start()
    {
        SpawnEnemy(enemy1_prefab, new Vector3(-8, 2, 0));
        SpawnEnemy(enemy2_prefab, new Vector3(8, 2, 0));
    }
    
    //�Ű����� 2�� (GameObject, Vector3) => Vector�� ��ġ�� Object�� ����
    void SpawnEnemy(GameObject prefab, Vector3 _position)
    {
        GameObject enemy = Instantiate(prefab);
        enemy.transform.position = _position;
        enemy.GetComponent<Enemy>().Move();
    }
}
