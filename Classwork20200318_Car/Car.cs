using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork202003_Car
{
    abstract class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }
       
        
        public Car(string model, int speed, int maxSpeed)
        {
            this.Model = model;
            this.Speed = speed;
            this.MaxSpeed = maxSpeed;
           
        }



        public delegate void CallBack();
        private CallBack msg;

        public void RegisterMsg(CallBack msg)
        {
            this.msg = msg;
        }

        public void Start()
        {
            Console.WriteLine($"Started {this.Model}... ");
            this.Speed = 10;
        }

        public void Accelerate()
        {
           
            Console.WriteLine($"Current speed of {this.Model} = {this.Speed}");
            this.Speed += 10;
            if (this.Speed > this.MaxSpeed)
            {
                Console.WriteLine("Too fast inside if");
            }

        }

        public void Stop(int speed)
        {
            this.Speed = speed;
            Console.WriteLine($"After full stop {this.Speed}");
        }

        public void Break(int speed)
        {
            this.Speed -= speed;
            Console.WriteLine($"After break stop {this.Speed}");
        }

        public abstract void ShowInfo();

    }


}

