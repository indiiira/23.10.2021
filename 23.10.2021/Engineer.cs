using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    class Engineer:Employee
    {

        public Engineer(string name, Department department, Sektor sektor, Employee head) : base(name, department, sektor, head)
        {

        }
    }
}
