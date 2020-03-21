using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork202003_Car
{
    class Ferrari: Car//спортивні
    {
        protected int EnginePower;
        public Ferrari(string model, int speed, int maxSpeed, int enginePower) : base(model, speed, maxSpeed)
        {
            this.EnginePower = enginePower;
        }

       

        public override void ShowInfo()
        {
            Console.WriteLine($"{this.Model},\tSpeed: {this.Speed},\tMaxSpeed: {this.MaxSpeed},\tEngine Power: {this.EnginePower}");
        }

       
    }
}
