using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Bear : Savetz, IRunning
    {
        public Bear(string name) : base(name) { }

        public void Move()
        {
            Console.WriteLine($"{this.Name} is running.");
        }

        

       

        public void Hugar()
        {
            Console.WriteLine($"{this.Name} love hugar");
        }


    }
}
