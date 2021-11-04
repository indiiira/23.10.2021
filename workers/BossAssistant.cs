using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workers
{
    class BossAssistant : Employee
    {
        public BossAssistant(string name, Department department, Employee head) : base(name, department, head)
        {

        }
    }
}
