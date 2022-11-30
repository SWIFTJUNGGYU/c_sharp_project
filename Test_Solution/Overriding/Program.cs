using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 오버라이딩(Overriding)
// 부모Class의 함수를 자식Class가 가공해서 사용.

// 오버라이딩(Overriding) 방법
// 1. 부모Class에서 오버라이딩 대상의 함수명 앞에 'virtual'
// 2. 자식Class에서는 상속받아 오버라이딩 할 대상의 함수명 앞에 'override'

// 상속의 연장선.
// 코딩문장을 덜 구현하기 위해서 오버라이딩(Overriding)을 쓴다.
// 부모Class 입장에서 자신의 함수를 상속받아서 쓰지만 자식Class 경우의 수가 다를때 사용.
// 생성자는 오버라이딩(Overriding)을 할 수 없다.

class BonusPayment
{
    protected string DepartmentName;
    protected int BonusPercent = 100;

    public virtual int GetBonus()
    {
        return BonusPercent;
    }

    public void DepartmentBonus(BonusPayment _bonusPayment)
    {
        int Bonus = _bonusPayment.GetBonus(); 
        BonusPercent = Bonus;

        Console.WriteLine(DepartmentName + " 부서의 상여금은 월급의 " + BonusPercent + "% 입니다.");
    }
}

class Developer : BonusPayment
{
    public Developer()
    {
        // 생성자에서 부서직원명 결정
        DepartmentName = "개발자";
    }
}

class Salesman : BonusPayment
{
    public Salesman()
    {
        // 생성자에서 부서직원명 결정
        DepartmentName = "영업사원";
    }

    public override int GetBonus()
    {
        int AddBonus = BonusPercent;
        int TotalBonus = AddBonus + BonusPercent;
        return TotalBonus;
    }
}

namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            Salesman salesman = new Salesman();

            developer.DepartmentBonus(developer);
            salesman.DepartmentBonus(salesman);
        }
    }
}
