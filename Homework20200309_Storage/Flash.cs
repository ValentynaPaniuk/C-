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
        private int Speed { get; set; } = 3;
        private double MemorySize { get; set; } 

        public Flash(string name, string model, int speed, double memorySize) : base(name, model)
        {
            this.Speed = speed;
            this.MemorySize = memorySize;
        }

        public override double GetMemorySize()
        {
            
            return this.MemorySize * 1024;
        }

        public override void CopyFile()
        {
            int copy = 576 * 1024;
            int res = copy / (int)this.GetMemorySize();
            Console.WriteLine($"If you want to copy ({copy} MB) to FLASH you will need: {res}");

            
        }
        public override void FreeMemory()
        {
            int copy = 576 * 1024;
            int res = copy / (int)this.GetMemorySize();

            double free = this.GetMemorySize() % 576;
            Console.WriteLine($"Free memory on one Flash: {free} MB");
            Console.WriteLine($"Free memory on all Flash: {free * res} MB");
        }
        public override void AllInformationMemory()
        {
            Console.WriteLine($"All information about Flash: {this.GetMemorySize()} ");
            CopyFile();
            FreeMemory();
        }


    }
}
