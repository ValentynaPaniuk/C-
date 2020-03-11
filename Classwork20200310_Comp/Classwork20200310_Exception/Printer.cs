using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200310_Exception
{
    class Printer: IPrintInformation
    {
        string Name = "Printer";
        public string GetName()
        {
            return this.Name;
        }

        public void Print(string str)
        {
            Console.WriteLine($"Print Printer str=>>>>>  {str}");
        }
    }
}
