using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample : MonoBehaviour
{
    private void Start()
    {
        //Human yangjunhyeok = new Human();
        //Debug.Log(yangjunhyeok.Height);
        //yangjunhyeok.Height = 10f;
        //Baby a = new Baby();
        //a.Height = 10f;
        //a.Run();

        //형변환
        //명시적 형변환
        //long c = 10;
        //int d = (int)c;
        //암시적 형변환 : 작은 자료형 -> 큰 자료형
        //int a = 10;
        //long b = a;

        //클래스는 명시적 형변환이 안되요
        Adult a = new Adult();
        Baby b = new Baby();

        a.Run();
        b.Run();

        //다양성
        //메서드 오버라이드
        //메서드를 재정의
    }
}
class Baby : Human
{
    //void Add(int a, int b)
    //{
    //    Debug.Log(a + b);
    //}
    //void Add(string a, string b)
    //{
    //    Debug.Log(a + b);
    //}
    public override void Run()
    {
        Debug.Log("아장아장");
    }
}
class Adult : Human
{

}
class Human
{
    //필드
    //필드
    private float height;
    public int age;
    public string name;
    //속성(프로퍼티)
    public float Height
    {
        get { return height; }
        set { height = value; }
    }
    //메서드
    public virtual void Run()
    {
        Debug.Log("Run!");
    }

    void Sleep()
    {

    }

    void Eat()
    {

    }
}