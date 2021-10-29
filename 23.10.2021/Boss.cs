using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    class Boss:Worker
    {

        public Boss()
        {

        }
        public Boss(string name, ref int lastID) : base(name, ref lastID)
        {

        }
        public Boss(string name, string surname, Worker head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
