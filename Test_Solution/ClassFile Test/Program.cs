using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스 파일(Class File)
// 클래스 정리 개념.
// 한 파일에 여러 클래스를 작성하지 않고
// 같은 프로젝트라면 클래스별로 파일을 분리시킬 수 있다.

// 클래스 파일 생성방법
// 해당 프로젝트 > 추가 > 새 항목 > 클래스(Class) 선택

namespace ClassFile_Test
{
    // 분리된 클래스파일(ClassInheritance.cs)을 상속받을 수 있다.
    class Program : ClassInheritance
    {
        static void Main(string[] args)
        {
            // 클래스파일로 분리 된 클래스(ClassFile.cs) 참조한 예시
            ClassFile classFile = new ClassFile();
            string ClassFileName = classFile.FileNameProperty;

            Console.WriteLine("참조한 Class File 명: " + ClassFileName);
        }

        void SecondFunc()
        {
            // 상속받은 클래스(ClassInheritance.cs)의 데이터 사용가능.
            int InheritanceAttackPoint = Attack;
            Console.WriteLine("상속받은 Attack POINT: " + InheritanceAttackPoint);
        }
    }

}
