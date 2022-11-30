using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 함수 오버로딩(Over Loading)
// 1. 함수명이 같아도 된다.
// 2. 대신 함수의 인자값 구성이 달라야 한다.
// 3. 모든 함수는 오버로딩이 적용가능하다.
//  - ex) 일반 함수, static 함수, 생성자

enum DepartmentType{
    SALES,
    TECH,
    PRODUCT
}

class Department
{

    public void SelectDepartment(string _departName, int _personCount)
    {
        Console.WriteLine("해당 부서명: " + _departName + " 부서 인원: " + _personCount + "명");
    }
    public void SelectDepartment(DepartmentType _departType)
    {
        string DepartmentName = "";
        int PersonCount = 0;

        switch (_departType)
        {
            case DepartmentType.SALES:
                DepartmentName = "영업부서";
                break;
            case DepartmentType.TECH:
                DepartmentName = "개발부서";
                break;
            case DepartmentType.PRODUCT:
                DepartmentName = "생산부서";
                break;
            default:
                DepartmentName = "미지정 부서";
                break;
        }

        SelectDepartment(DepartmentName, PersonCount);
    }
    public void SelectDepartment(int _departNo, int _personCount)
    {
        string DepartmentName = "";

        if (_departNo == 1)
        {
            DepartmentName = "영업부서";
        }
        else if (_departNo == 2)
        {
            DepartmentName = "개발부서";
        }
        else if (_departNo == 3)
        {
            DepartmentName = "생산부서";
        }
        else
        {
            DepartmentName = "미지정 부서";
        }

        SelectDepartment(DepartmentName, _personCount);
    }

}

namespace Overloading_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.SelectDepartment(DepartmentType.SALES);
            department.SelectDepartment(2, 100);

        }
    }
}
