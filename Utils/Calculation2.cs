using ConsoleApp03012.MyTask2Classes;
using ConsoleApp0312.MyTask2Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0312
{
    public class Calculation2
    {
        public static RelayTeam GetBestRunners(Students[] students)
        {         
            Array.Sort(students, (s1, s2) => s1.RunTime.CompareTo(s2.RunTime));
        
            Students[] bestRunners = new Students[4];
            for (int i = 0; i < 4; i++)
            {
                bestRunners[i] = students[i];
            }

            return new RelayTeam(bestRunners);
        }
    }
}
