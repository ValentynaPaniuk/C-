using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200310_Exception
{
    class Monitor : IPrintInformation
    {
        string Name;
        public string GetName()
        {
            return this.Name;
        }

        public void Print(string str)
        {
            Console.WriteLine($"Print Monitor str =>>>>>  {str}");
        }
    }
}
