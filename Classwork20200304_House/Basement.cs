﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Basement :IPart
    {
        string str;

        public Basement()
        {
            str =  "============";
        }

        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"1. Basement\n{str}");

        }

    }
}
