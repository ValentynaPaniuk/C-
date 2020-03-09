using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Worker:IWorker
    {

        protected string name { get; set; }
        protected House house { get; set; }

        public Worker()  {  Console.WriteLine("Default constructor"); }

        public Worker(string name, House house)
        {
            this.name = name;
            this.house = house;
            Console.WriteLine("Overload constructor(Name,House)");
        }

       
        
        public void Work()
        {
            Console.WriteLine("My name is {0}.", name);
        }

        public void ShowHouse()
        {
            house.ShowData();
            house.Basement.ShowData();
            house.Walls.ShowData();
            house.Door.ShowData();
            house.Window.ShowData();
            house.Roof.ShowData();
        }
    }
    
}
