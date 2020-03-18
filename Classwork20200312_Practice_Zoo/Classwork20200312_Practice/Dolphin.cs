using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Dolphin: Savetz, IFloating
    {
        public Dolphin(string name) : base(name) { }

        public void Move()
        {
            Console.WriteLine($"{this.Name} is floating");
        }

        
    }
}
