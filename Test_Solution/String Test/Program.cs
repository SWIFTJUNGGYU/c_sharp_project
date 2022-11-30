using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// string이란?
// 1. 문자열을 의미한다.
//  - 추가로 문자 하나만 쓸수 있는 자료형: char character = 'a'; (홑따옴표로 표시)
// 2. 동적 기본자료형이다.
//  - 반면 int는 4byte의 고정 크기의 정적 기본자료형이다.

// 자료형이란
// C#에서 만들어준비한 기본구조체(Struct)이다.

namespace String_Test
{
    enum EnnumTest
    {
        A01 = 0,
        A02,
        A03
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 자료형이 다르면 Red Line
            int A = "가나다";
            int B = EnnumTest.A01;  // Enum의 순차데이터가 있다고 해도 형변환이 필요함.

            char charater = 'a';
            string stringChar = "abcdefg";

        }
    }
}
