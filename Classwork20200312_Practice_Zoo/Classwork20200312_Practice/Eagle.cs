using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Eagle:Bird,IFlying
    {
        public Eagle(string name) : base(name) { }

        public void Move()
        {
            Console.WriteLine($"{this.Name} is flying... ");
        }

      
    }
}
