using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20200309_Storage
{
    class HDD : Storage
    {
        //■ класс съемный HDD: скорость USB 2.0, количество разделов, объем разделов.
        private int Speed;
        private int NumberOfSections;
        private double VolumeOfSections; 
        public HDD(string name, string model, int speed, int numberOfSections, double volumeOfSections ) : base(name, model) 
        {
            this.Speed = speed;
            this.NumberOfSections = numberOfSections;
            this.VolumeOfSections = volumeOfSections;
        }
        public override double GetMemorySize()
        {
            return this.NumberOfSections * VolumeOfSections*1024;
        }
        public override void CopyFile()
        {
            int copy = 576 * 1024;
            int res = copy / (int)this.GetMemorySize();
            Console.WriteLine($"If you want to copy ({copy} MB) to HDD you will need: {res}");
            
        }
        public override void FreeMemory()
        {
            int copy = 576 * 1024;
            int res = copy / (int)this.GetMemorySize();

            double free = this.GetMemorySize() % 576;
            Console.WriteLine($"Free memory on one HDD: {free} MB");
            Console.WriteLine($"Free memory on all HDD: {free*res} MB");
        }
        public override void AllInformationMemory()
        {
            Console.WriteLine($"All information about HDD: {this.GetMemorySize()}");
            CopyFile();
            FreeMemory();
        }
    }
   

    
}
