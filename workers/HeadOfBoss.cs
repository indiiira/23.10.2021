using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workers
{
    class HeadOfBoss : Employee
    {
        public HeadOfBoss(string name, Department department, Employee head) : base(name,department, head)
        {

        }
    }
}
