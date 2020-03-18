using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Savetz : Animal
    {
        public Savetz(string name) : base(name) { }

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
             
    





