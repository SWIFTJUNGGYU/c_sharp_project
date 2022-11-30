using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Class 안에 Class를 선언하는 방법
// 이유 = Inner Class의 내용을 함부로 참조할 수 없게 하기 위한 수단

namespace Inner_Class_Test
{
    class LocationKorea
    {
        private string seoulNumber = "02";

        class Kangwon
        {
            void LocationNumber()
            {
                // 특정 Class 안에 선언된 Inner Class라고 연결되어 있는 구조 아님.
                // 연관성 없는 각자 다른 Class로 인식되어 진행된다.

                // 변수 seoulNumber는
                // LocationKorea Class에 선언된 private 변수이기 때문에
                // Kangwon Class에서는 참조할 수 없다.

                // seoulNumber = "033";
            }
        }

        class Jeju
        {
            // LocationKorea Class에 선언된 private 변수를 참조하기 위해서는
            // Inner Class의 인자값으로 LocationKorea Class를 받아서
            // seoulNumber 변수를 참조할 수 있다.

            void LocationNumber(LocationKorea _locKr)
            {
                string jejuNumber = "064";
                _locKr.seoulNumber = jejuNumber;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
