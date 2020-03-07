using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Window : IPart
    {
        string str;
        public Window()
        {
            str =  "***\n: :\n***";
        }

        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        public void ShowData()
        {
            Console.WriteLine(($"4. Window\n{str}"));

        }

       
    }
}
