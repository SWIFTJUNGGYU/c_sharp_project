using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로퍼티(Property)란?
// Get(), Set() 함수 개념

class PropertyTest
{
    int Point = 10;

    public int GetPoint()
    {
        return Point;
    }

    public void SetPoint(int _Value)
    {
        Point = _Value;
    }

    // 프로퍼티(Property)
    // 1. get에 관하여 Return의 자료형은 Property에 지정된 Return 자료형이다.
    // 2. set의 인자값의 자료형 또한 Property에 지정된 Return 자료형으로 인식되어 value로 통칭한다. 
    public int PointProperty
    {
        get
        {
            return Point;
        }

        set
        {
            Point = value;
        }
    }
}

namespace Property_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PropertyTest propertyTest = new PropertyTest();

            // Set함수 적용 예시
            propertyTest.SetPoint(100);

            // Get함수 적용 예시
            int returnPoint = propertyTest.GetPoint();
            Console.WriteLine("POINT Get: " + returnPoint);

            // 프로퍼티 Set 적용 예시
            propertyTest.PointProperty = 200;

            // 프로퍼티 Get 적용 예시
            int returnPropertyPoint = propertyTest.PointProperty;
            Console.WriteLine("Property POINT Get: " + returnPropertyPoint);
        }
    }
}
