using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class Team : IWorker
    {
        protected House house = new House();
        protected List<IPart> parts = new List<IPart>();
       

        protected int counterBasement = 1;
        protected int counterWalls = 4;
        protected int counterDoor = 1;
        protected int counterWindow = 4;
        protected int counterRoof = 1;

        public void Work()
        {
           
            Console.WriteLine(" Start of construction: ");

            house.ShowData();
            while (counterBasement != 0)
            {
                parts.Add(new Basement()); counterBasement--;
            }
            while (counterWalls != 0)
            {
                parts.Add(new Walls()); counterWalls--;
            }
            while (counterDoor != 0)
            {
                parts.Add(new Door()); counterDoor--;
            }
            while (counterWindow != 0)
            {
                parts.Add(new Window()); counterWindow--;
            }
            while (counterRoof != 0)
            {
                 parts.Add(new Roof()); counterRoof--;
          
            }
         
        }


        public void ShowHouse()
        {
            foreach (var e in parts)
            {
                e.ShowData();
            }
            Console.WriteLine("Team said: The house is built! ");
           
        }


    }
}
