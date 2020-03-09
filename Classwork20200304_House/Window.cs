using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Window : IPart
    {
        string part;
        public Window() { part =  "***\n: :\n***"; }

       

        public void ShowData()
        {
            Console.WriteLine(($"4. Window\n{part}"));

        }

       
    }
}
