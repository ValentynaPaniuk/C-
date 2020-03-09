using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Basement :IPart
    {
        string part { get; set; }

        public Basement()  { part =  "============"; }


        public void ShowData()
        {
            Console.WriteLine($"1. Basement\n{part}");

        }

    }
}
