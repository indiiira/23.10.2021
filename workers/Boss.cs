﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workers
{
    class Boss : Employee
    {
        public Boss(string name, Employee head) : base(name, head)
        {

        }
    }
}
