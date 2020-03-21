using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork202003_Car
{
    class Mercedes:Car//Вантажні
    {
        int Tonnage { get; set; }
        public Mercedes(string model, int speed, int maxSpeed, int tonnage) : base(model, speed, maxSpeed)
        {
            this.Tonnage = tonnage;

        }

      

        public override void ShowInfo()
        {
            Console.WriteLine($"{this.Model},\tSpeed: {this.Speed},\tMaxSpeed: {this.MaxSpeed},\tTonnage: {this.Tonnage}");
        }

        

    }
}
