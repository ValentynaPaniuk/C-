using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Door : IPart
    {
        string part { get; set; }


        public Door() { part = "===\n| |\n==="; }

        public void ShowData()
        {
            Console.WriteLine(($"3. Door\n{part}"));
           
        }
    }
}

