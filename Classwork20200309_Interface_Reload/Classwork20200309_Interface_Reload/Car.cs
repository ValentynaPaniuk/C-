using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200309_Interface_Reload
{
    class Car : IVehicle
    {
        public string Engine { get; set; }
        Car() { Console.WriteLine("Default constructor"); }
        Car(string engine) { this.Engine = engine; Console.WriteLine("Overload constructor"); }
    }
}
