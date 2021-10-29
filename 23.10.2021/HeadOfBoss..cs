using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    class HeadOfBoss : Employee
    {
        public HeadOfBoss(string name, string surname, Department department, Employee head) : base(name, surname, department, head)
        {

        }
    }
}

