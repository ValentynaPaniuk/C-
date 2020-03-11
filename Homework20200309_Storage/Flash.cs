using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20200309_Storage
{
    class Flash:Storage
    {
        //■ класс Flash-память: скорость USB 3.0, объем памяти;
        private int Speed;
        private double MemorySize;

        public Flash(string name, string model, int speed, double memorySize) : base(name, model)
        {
            this.Speed = speed;
            this.MemorySize = memorySize;
        }

        public override double GetMemorySize() { return this.MemorySize; }
        public override void CopyFile() { Console.WriteLine($"Copy on Flash"); }
        public override void FreeMemory() { Console.WriteLine($"Free memory Flash: "); }
        public override void AllInformationMemory() { Console.WriteLine($"All information about Flash: "); }


    }
}
