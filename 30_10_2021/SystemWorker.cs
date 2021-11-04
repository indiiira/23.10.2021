using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_10_2021
{
    class SystemWorker : Worker
    {
        public SystemWorker()
        {

        }
        public SystemWorker(string name, ref int lastID, Worker head) : base(name, ref lastID, head)
        {

        }
        public SystemWorker(string name, string surname, Worker head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}