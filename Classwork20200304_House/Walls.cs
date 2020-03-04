using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Walls
    {
        string str;
        public Walls()
        {
            str = "|\n|\n|\n|\n|\n";
        }

        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        public void ShowData()
        {
           
            Console.WriteLine(($"Walls\n{str}"));
        }




         
    }
}
