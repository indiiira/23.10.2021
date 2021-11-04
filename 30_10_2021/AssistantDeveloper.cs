using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_10_2021
{
    class AssistantDeveloper : Worker
    {
        public AssistantDeveloper(string name, ref int lastID, Worker head) : base(name, ref lastID, head)
        {

        }
        public AssistantDeveloper(string name, string surname, Worker head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
