using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_Enum_Test
{
    class Player
    {
        // 특정 열거형 자료(enum)을 특정 Class에서만 사용할 때
        // 해당 Class 안에서 선언하여 사용 하는 법
        // 특징: 열거자 명의 중복성을 해결 할 수 있다.

        enum PlayerJob
        {
            Programer,
            Teacher,
            Chief,
            Doctor,
            Repairman,
            Police
        }

        PlayerJob manJob = PlayerJob.Doctor; 
    }

    class Arrow
    {
        public enum ArrowKind
        {
            Center,
            Left,
            Right,
            Up,
            Down
        }

        ArrowKind arrowLeft = ArrowKind.Left;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            Arrow newArrow = new Arrow();

            // 다른 Class에서 Inner Enum 데이터를 참조하고 싶을 때
            Arrow.ArrowKind arrowLeft = Arrow.ArrowKind.Left;

            // 'public' 으로 선언 된 열거자(Enum)만 참조하여 사용할 수 있다.
            //Player.PlayerJob chief = Player.PlayerJob.Chief;
        }
    }
}
