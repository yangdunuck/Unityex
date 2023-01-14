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
//추상클래스
//자식클래스에서 반드시 메서드를 재정의하게 할 떄 사용
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