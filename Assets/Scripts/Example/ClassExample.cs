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

        //����ȯ
        //����� ����ȯ
        //long c = 10;
        //int d = (int)c;
        //�Ͻ��� ����ȯ : ���� �ڷ��� -> ū �ڷ���
        //int a = 10;
        //long b = a;

        //Ŭ������ ����� ����ȯ�� �ȵǿ�
        Adult a = new Adult();
        Baby b = new Baby();

        a.Run();
        b.Run();

        //�پ缺
        //�޼��� �������̵�
        //�޼��带 ������
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
        Debug.Log("�������");
    }
}
class Adult : Human
{

}
class Human
{
    //�ʵ�
    //�ʵ�
    private float height;
    public int age;
    public string name;
    //�Ӽ�(������Ƽ)
    public float Height
    {
        get { return height; }
        set { height = value; }
    }
    //�޼���
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