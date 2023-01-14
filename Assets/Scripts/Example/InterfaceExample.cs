using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceExample : MonoBehaviour
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
//인터페이스
//추상클래스와 비슷
//차이점 : 인터페이스는 여러개를 장착할 수 있음
interface Ianimal
{
    void Run();
}
class Cat : Ianimal
{
    public void Run()
    {

    }
}


