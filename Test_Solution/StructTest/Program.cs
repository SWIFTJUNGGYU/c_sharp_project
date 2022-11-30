using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 구조체(Struct)
// Class개념과 비슷하지만 다른 것
// 1. 맴버변수의 값을 미리 지정할 수 없다.(리터럴 초기화 안됨)
// 2. Class = 레퍼런스 형, Struct = 값 형
// 3. Struct를 참조시 Stack메모리 영역에 Struct 데이터가 복사되는 개념

// ** 결론 **
// 함수 시작시 구조체(Struct)는 Stack 메모리에 새로 만들어진다.
// 함수에서 사용한 구조체(Struct)는 함수 종료시 Stack 메모리에서 제거된다.

struct StructData
{
    public int a;
    public int b;
}

namespace Struct_Test
{
    public class Program
    {

        static void StructTest(StructData _structData)
        {
            _structData.a = 1000;

            // Struct a변수 값 = 1000; (이 함수에서만 Struct a변수 값이 변한다.)
            Console.WriteLine("StructTest함수 적용 Struct맴버변수 a값: " + _structData.a);
        }

        static void Main(string[] args)
        {
            //Struct 선언 방식(Class 선언 방식와 유사)
            StructData NewStructData = new StructData();
            NewStructData.a = 10;

            // Struct 인자를 받는 함수요청
            StructTest(NewStructData);

            // Struct a변수 값 = 10; (Struct a변수 값이 변하지 않는다.)
            Console.WriteLine("StructTest함수 적용 후 Main함수 Struct맴버변수 a값: " + NewStructData.a);
        }
    }
}