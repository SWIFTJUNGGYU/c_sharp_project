using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열(Array)
// 어떠한 데이터가 모여있는 형태의 기본자료형이다.

// 선언방식= 어떠한 자료형[]
// ex) int[] arrayInt = new int[5];
//     - 5칸의 int형 배열 생성의 뜻
//     - 결과 모습: [0][0][0][0][0]

// 특징: 각 배열의 칸은 순서있게 붙어있다.(Index를 가짐)
// ex) arrayInt[3];
//     - int배열 5칸 중 3칸에 있는 데이터 Get

namespace Array_Test
{
    class Character
    {
        public string Name;
        public int Age;
        public bool Sex;
        public short Tall;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 5칸의 int형 배열 생성
            int[] ArrayInt = new int[5];

            // 3번째 칸의 배열에 900 데이터 삽입
            ArrayInt[2] = 900;
            Console.WriteLine("3번째 칸의 배열에 데이터: "  + ArrayInt[2]);

            //---------------------------------------------------------------------------//

            // Character Class 3칸 배열 선언
            // Character라는 참조형을 가리킬 수 있는 공간이 3개 생겼다는 의미
            Character[] ArrayCharacter = new Character[3];

            // Class는 레퍼런스형이기 때문에 Charcter Class배열 안에 각각 객체 생성해야한다.
            // Character 생성의 의미
            for (var i=0; i< ArrayCharacter.Length; i++)
            {
                ArrayCharacter[i] = new Character();
            }

            // 생성된 Class 배열에 데이터 삽입
            ArrayCharacter[0].Name = "Ryan";
            ArrayCharacter[0].Age = 7;
            ArrayCharacter[0].Sex = true;
            ArrayCharacter[0].Tall = 150;

            ArrayCharacter[1].Name = "Muzi";
            ArrayCharacter[1].Age = 9;
            ArrayCharacter[1].Sex = false;
            ArrayCharacter[1].Tall = 160;

            ArrayCharacter[2].Name = "Apeach";
            ArrayCharacter[2].Age = 5;
            ArrayCharacter[2].Sex = true;
            ArrayCharacter[2].Tall = 120;

            Console.WriteLine("캐릭터 소개");
            Console.WriteLine("----------------------");
            for (var i=0; i< ArrayCharacter.Length; i++)
            {
                Console.WriteLine("이름: " + ArrayCharacter[i].Name);
                Console.WriteLine("나이: " + ArrayCharacter[i].Age);
                Console.WriteLine("성별: " + ArrayCharacter[i].Sex);
                Console.WriteLine("키: " + ArrayCharacter[i].Tall);
                Console.WriteLine("----------------------");
            }


        }
    }
}
