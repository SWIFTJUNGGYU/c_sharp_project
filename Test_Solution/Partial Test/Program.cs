using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 파티셜(Partial)
// Class를 다시한번 분할화하여 파일로 관리하는 방법
// 1. 분할 된 Class 명 앞에 'partial' 명칭 기재
//    예시) Job.cs, Job.Doctor.cs

namespace Partial_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job job = new Job();
            int JobNunmber = job.SelectJob("Doctor");

            switch (JobNunmber)
            {
                case 1:
                    
                    break;
                case 2:
                    // 파티셜로 분리된 JobDoctor.cs라는 Class File 참조 함.
                    job.SelectDoctor();
                    break;
                case 3:

                    break;

                default:
                    break;
            }


        }
    }
}
