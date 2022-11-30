using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Fight
{
    protected int AttackPoint = 100;
    protected string UnitName = "none";

}

class Player : Fight
{
    // 생성자(Class Constructor)란? 
    // 1. 리턴값을 따로 지정하지 않는 함수. (리턴값 = 자신의 Class로 고정 됨)
    // 2. Class호출 시 무조건 한번 실행되어주는 함수.
    // 3. Heap영역에 메모리가 만들어질 때 호출되어지는 함수.
    // 4. 상속받은 Class의 데이터도 활용할 수 있다.
    public Player()
    {
        // 상속받은 Class 변수 활용
        AttackPoint += 100;
        UnitName = "플레이어";

        int ConstructorCount = 0;
        Console.WriteLine(UnitName + " 생성자 호출 Count: " + ConstructorCount);
    }
}

namespace Class_Constructor_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class 참조시 호출되는 new Player() 함수가 생성자(Class Constructor)
            // 결국 생성자는 "자신의 Class를 리턴해주는 함수"
            Player player = new Player();
        }

    }
}
