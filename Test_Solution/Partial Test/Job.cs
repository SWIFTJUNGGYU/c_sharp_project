using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Job
{
    public int SelectJob(String _jobName)
    {
        int JobNo = 0;

        switch (_jobName)
        {
            case "Programer":
                JobNo = 1;
                break;
            case "Doctor":
                JobNo = 2;
                break;
            case "Salesman":
                JobNo = 3;
                break;
            default:
                break;
        }

        return JobNo;
    }

}

