using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork202003_Car
{
    class Toyota:Car//Легкові
    {
        protected string BodyType;
        public Toyota(string model, int speed, int maxSpeed, string bodyType) : base(model, speed, maxSpeed )
        {
            this.BodyType = bodyType;
        }

        public void Refuel()
        {
            Console.WriteLine($"{this.Model} refueled");
        }

        public void Repair()
        {
            Console.WriteLine($"{this.Model} repaired");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{this.Model},\tSpeed: {this.Speed},\tMaxSpeed: {this.MaxSpeed},\tBody Type: {this.BodyType}");
        }

        public void TurnLeft()
        {
            Console.WriteLine($"{this.Model} turned to the left");
        }

        public void TurnRight()
        {
            Console.WriteLine($"{this.Model} turned to the right");
        }

        public void WashCar()
        {
            Console.WriteLine($"{this.Model} washed");
        }

        public void СhangeTire()
        {
            Console.WriteLine($"{this.Model} the tires were changed");
        }

    }
}
