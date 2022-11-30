using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Enum이란? '열거자'라는 뜻
// 사용자 정의 자료형
// 1. 개발자가 정한 명찰 개념
// 2. 레퍼런스형이 아닌 값형의 데이터
enum Job
{
    Programer,
    Lawyer,
    Doctor,
    Salesman,
    NoneSelect

}

class SelectJob
{
    public Job job = Job.NoneSelect;

    public void SelectDoctor()
    {
        job = Job.Doctor;
    }
}

namespace Enum_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectJob selectJob = new SelectJob();

            // Enum은 열거된 데이터로만 변경가능하다.
            selectJob.job = Job.Programer;
            Console.WriteLine("Job.Programer = "+ selectJob.job);

            selectJob.SelectDoctor();
            Console.WriteLine("SelectDoctor() = " + selectJob.job);

            // Enum은 switch문으로 자동완성 기능이 가능하다.
            // 자동완성 단축키: Alt + Enter
            Job job = Job.NoneSelect;

            switch (job)
            {
                case Job.Programer:
                    break;
                case Job.Lawyer:
                    break;
                case Job.Doctor:
                    break;
                case Job.Salesman:
                    break;
                case Job.NoneSelect:
                    break;
            }
        }
    }
}
