using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Roof : IPart
    {
        string part { get; set; }
        public Roof() {  part =  "-----------";   }


        public void ShowData()
        {
            Console.WriteLine(($"5. Roof\n{part}"));

        }


       
    }
}
