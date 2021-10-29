using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{

    class MainEngineer : Employee
    {
        public MainEngineer(string name, Department department, Sektor sektor, Employee head) : base(name, department, sektor, head)
        {

        }
    }
}