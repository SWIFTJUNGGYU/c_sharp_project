using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassFile
{
    string ClassFileName = "클래스 파일명";

    public string FileNameProperty
    {
        get
        {
            return ClassFileName;
        }

        set
        {
            ClassFileName = value;
        }
    }
}

