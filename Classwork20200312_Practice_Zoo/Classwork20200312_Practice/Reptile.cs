using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Reptile : Animal
    {
        public Reptile(string name) : base(name) { }

        public void ColdBlood()
        {
            Console.WriteLine($"{this.Name} has cold blood");
        }

    }
}
