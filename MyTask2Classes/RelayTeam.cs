using ConsoleApp03012.MyTask2Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0312.MyTask2Classes
{
    public class RelayTeam
    {
        public Students[] TeamMembers { get; set; }

        public RelayTeam(Students[] teamMembers)
        {
            TeamMembers = teamMembers;
        }

        public void PrintTeam()
        {
            Console.WriteLine("Команда из четырех лучших бегунов:");
            foreach (var member in TeamMembers)
            {
                Console.WriteLine($"{member.LastName}: {member.RunTime} сек");
            }
        }
    }
}
