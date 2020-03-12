using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Bear : Owl, IRunning
    {
        public Bear(string name) : base(name) { }

        public void Move()
        {
            Console.WriteLine($"{this.Name} is running.");
        }

        

        public void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping.");
        }
        public void Wool()
        {
            Console.WriteLine($"{this.Name} has wool");
        }


    }
}
