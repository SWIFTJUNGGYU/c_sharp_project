using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 제네릭(Generic) 이란?
// 범용성 타입의 인자 값으로 받아 로직을 진행하는 방식
// 사용법: Class명 또는 Method명 오른쪽에 <T> (꺽쇠괄호)
//  - 인자의 갯수에 따라 제네릭 타입의 갯수도 늘어날 수 있다.
//  - ex) 제네릭 인자 갯수 2개일 때 <T, U>

namespace Generic_Test
{
    // [Generic Class Case]
    // Class명 오른쪽에 Generic 타입 선언

    class GenericClassTest<T>
    {
        // Generic Member
        public T getSetData { get; set; }
    }

    class GenericMethodTest
    {
        // [Generic Method Case]
        // Generic Mothod 경우 Input타입과 Output타입의 제네릭 타입을 지정할 수 있다. 
        public static T PaymentOfJob<T, U> (T _job, U _pay){

            Console.WriteLine("직업: " + _job + " - 연봉: " + _pay);
            return _job;
        }

        // Generic 타입의 변경으로 Method의 Overloading 가능하다
        public static U PaymentOfJob<U>(U _pay)
        {
            Console.WriteLine("평균 직장인 - 연봉: " + _pay);
            return _pay;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Class 인스턴스를 선언할 때
            // 입력 할 Generic 타입을 지정해줘야한다.
            GenericClassTest<int> genericIntData = new GenericClassTest<int>();
            GenericClassTest<string> genericStringData = new GenericClassTest<string>();

            genericIntData.getSetData = 7000;
            genericStringData.getSetData = "Generic String Data";

            Console.WriteLine($"{genericStringData.getSetData}: {genericIntData.getSetData: #,###}");

            // Generic Method의 호출 시
            // 인자값 타입에 의하여 Generic 타입이 정해진다.
            // Generic 타입의 Output이 존재할 시 그에 맞는 타입의 변수를 선언하여야 한다.
            string rtnJob = GenericMethodTest.PaymentOfJob("의사", 8000);
            int rtnPay = GenericMethodTest.PaymentOfJob(4000);



        }
    }
}
