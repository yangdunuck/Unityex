using UnityEngine;

public class StructExample : MonoBehaviour
{
    private void Start()
    {
        //Point_Struct a = new Point_Struct();
        PointClass pointClass_1 = new PointClass(10);
        PointStruct pointStruct_1 = new PointStruct(10);

        PointClass pointClass_2 = pointClass_1;
        PointStruct pointStruct_2 = pointStruct_1;

        pointClass_1.point = 20;
        pointStruct_1.point = 20;

        Debug.Log($"PointClass2 : {pointClass_2.point}");
        Debug.Log($"PointStruct2 : {pointStruct_2.point}");
    }
}
//구초제
//클래스와 유사
//struct Point_Struct
//{
//    public float point_x;
//    public float point_y;
//    public float point_z;

//    Point_Struct(float x, float y,float z)
//    {
//        point_x = x;
//        point_y = y;
//        point_z = z;
//    }

//    public string GetPoint()
//    {
//        return $"{point_x}, {point_y}, {point_z}";
//    }
//}

//클래스와 구조체의 차이점
class PointClass
{
    public int point;
    public PointClass(int _point)
    {
        this.point = _point;
    }
}

struct PointStruct
{
    public int point;
    public PointStruct(int _point)
    {
        this.point = _point;
    }
}

//값형과 참조형
