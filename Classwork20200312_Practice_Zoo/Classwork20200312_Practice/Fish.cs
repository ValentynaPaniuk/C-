using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Fish : Animal
    {
        public Fish(string name) : base(name) { }

        public void Scales()
        {
            Console.WriteLine($"{this.Name} has scales");
        }
    }

}
