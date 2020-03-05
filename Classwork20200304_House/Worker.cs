using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Worker
    {

        protected string name;
        protected House house;

        public Worker()
        {
            name = "Stive";
            house = new House(150);
        }

        public Worker(string name, House house)
        {
            this.name = name;
            this.house = house;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public House House
        {
            get { return house; }
            set { house = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Roof.ShowData();
            house.Window.ShowData();
            house.Walls.ShowData();
            house.Door.ShowData();
            house.Basement.ShowData();



        }
    }
    
}
