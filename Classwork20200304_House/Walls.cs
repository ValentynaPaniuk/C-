using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Walls : IPart
    {
        string part { get; set; }
        public Walls() { part = "|\n|\n|\n|\n|\n"; }

       
        public void ShowData()
        {
           Console.WriteLine(($"2. Walls\n{part}"));
        }
                                       
    }
}
