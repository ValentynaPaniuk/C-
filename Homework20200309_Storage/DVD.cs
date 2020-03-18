using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20200309_Storage
{
    class DVD:Storage
    {
        // класс DVD-диск: скорость чтения / записи, тип (односторонний (4.7 Гб) /двусторонний (9 Гб));
        private int ReadSpeed;
        private int RecordingSpeed;
        private double Type;

        public DVD(string name, string model, int readSpeed, int recordingSpeed, double type) : base(name, model)
        {
            this.ReadSpeed = readSpeed;
            this.RecordingSpeed = recordingSpeed;
           
            if (type == 1)
            {
                this.Type = 4.7;
            }
            else if (type == 2)
            {
                this.Type = 9;
            }
            
        }


        public override double GetMemorySize()
        {
            
            return this.Type * 1024;
        }
        public override void CopyFile()
        {
            int copy = 576 * 1024;
            int res = copy / (int)this.GetMemorySize();
            Console.WriteLine($"If you want to copy ({copy} MB) to DVD you will need:{res}");

                                           
        }
        public override void FreeMemory()
        {
            int copy = 576 * 1024;
            int res = copy / (int)this.GetMemorySize();

            double free = this.GetMemorySize() % 576;
            Console.WriteLine($"Free memory on one DVD: {free} MB");
            Console.WriteLine($"Free memory on all DVD: {free * res} MB");

        }
        public override void AllInformationMemory()
        {
            Console.WriteLine($"All information about DVD: {this.GetMemorySize()}: ");
            CopyFile();
            FreeMemory();

        }



    }
}
