using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork202003_Car
{
    class Neoplan:Car//Автобуси
    {
        protected int NumberOfPassengers;
        public Neoplan(string model, int speed, int maxSpeed, int numberOfPassengers) : base(model, speed, maxSpeed)
        {
            this.NumberOfPassengers = numberOfPassengers;
        }

        

        public override void ShowInfo()
        {
            Console.WriteLine($"{this.Model},\tSpeed: {this.Speed},\tMaxSpeed: {this.MaxSpeed},\tNumber of passengers: {this.NumberOfPassengers}");
        }

       

        

    }
}
