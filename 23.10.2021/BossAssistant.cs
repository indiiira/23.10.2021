using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    class BossAssistant:Worker
    {
        public BossAssistant()
        {

        }
        public BossAssistant(string name, ref int lastID, Worker head) : base(name, ref lastID, head)
        {

        }
        public BossAssistant(string name, string surname, Worker head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
