using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Roof : IPart
    {
        string str;
        public Roof()
        {
            str =  "-----------";
        }

        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        public void ShowData()
        {
            Console.WriteLine(($"Roof\n{str}"));

        }


       
    }
}
