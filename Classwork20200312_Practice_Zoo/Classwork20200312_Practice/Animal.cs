using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    abstract class Animal
    {
        protected string Name { get; set; }

        public Animal(string name) { this.Name = name; }

        public void Live()
        {
            Console.WriteLine($"{this.Name} is living.");
        }

        public void Eating()
        {
            Console.WriteLine($"{this.Name} is eating.");
        }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name} is breathing.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"It is {this.Name}.");
        }


    }
}
