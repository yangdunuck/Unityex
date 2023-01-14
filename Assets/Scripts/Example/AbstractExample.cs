using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//�߻�Ŭ����
//�ڽ�Ŭ�������� �ݵ�� �޼��带 �������ϰ� �� �� ���
abstract class Animal
{
    public abstract void Run();
    public void Eat()
    {
        Debug.Log("Eat");
    }
}
class Bird : Animal
{
    public override void Run()
    {
        Debug.Log("Fly");
    }
}
class Fish : Animal
{
    public override void Run()
    {
        Debug.Log("Swim");
    }
}

class Dog : Animal
{
    public override void Run()
    {
        Debug.Log("Run");
    }
}