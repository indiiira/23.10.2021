using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    class MainDeveloper : Worker
    {
        public MainDeveloper()
        {

        }
        public MainDeveloper(string name, ref int lastID, Worker head) : base(name, ref lastID, head)
        {

        }
        public MainDeveloper(string name, string surname, Worker head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }

    }

}
