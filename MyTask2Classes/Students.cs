using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03012.MyTask2Classes
{
    public class Students
    {
        public string LastName { get; }
        public double RunTime { get; }

        public Students(string lastName, double runTime)
        {
            LastName = lastName;
            RunTime = runTime;
        }
    }
}
