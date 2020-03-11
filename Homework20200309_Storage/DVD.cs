using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20200309_Storage
{
    class DVD:Storage
    {
        //■ класс DVD-диск: скорость чтения / записи, тип
        private int ReadSpeed;
        private int RecordingSpeed;
        private double Type;

        public DVD(string name, string model, int readSpeed, int recordingSpeed, double type) : base(name, model)
        {
            this.ReadSpeed = readSpeed;
            this.RecordingSpeed = recordingSpeed;
            this.Type = type;
        }


        public override double GetMemorySize() { return this.Type; }
        public override void CopyFile() { Console.WriteLine($"Copy on DVD"); }
        public override void FreeMemory() { Console.WriteLine($"Free memory DVD: "); }
        public override void AllInformationMemory() { Console.WriteLine($"All information about DVD: "); }



    }
}
