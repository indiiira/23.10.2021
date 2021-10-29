using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    class AssistantSystemWorker:Employee
    { 
   
        public AssistantSystemWorker(string name, ref int lastID, Employee head) : base(name, ref lastID, head)
        {

        }
        public AssistantSystemWorker(string name, string surname, Employee head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
