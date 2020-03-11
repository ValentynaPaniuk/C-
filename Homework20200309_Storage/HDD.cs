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
        public override double GetMemorySize() { return this.NumberOfSections * VolumeOfSections; }
        public override void CopyFile() { Console.WriteLine($"Copy on HDD"); }
        public override void FreeMemory() { Console.WriteLine($"Free memory HDD: "); }
        public override void AllInformationMemory() { Console.WriteLine($"All information about HDD: "); }
    }
   

    
}
