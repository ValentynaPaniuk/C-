using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200310_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Comp computer = new Comp(2,3);
            IPrintInformation pr = new Monitor();
            computer.AddDevice(1, pr);
            computer.AddDevice(2, pr);

            computer.ShowPrintDevice();

            Disk d = new CD();
            computer.AddDisk(0, d);
            computer.AddDisk(1, d);
            computer.AddDisk(2, d);
            computer.AddDisk(3, d);
            computer.ShowDisk();
           
            
            
            
           

            
        }
    }
}