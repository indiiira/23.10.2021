using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    class AssistantDeveloper:Employee
    {
        
        public AssistantDeveloper(string name, ref int lastID, Employee head) : base(name, lastID, head)
        {

        }
        public AssistantDeveloper(string name,  Employee head, ref int lastID) : base(name, head, ref lastID)
        {

        }
    }
}
