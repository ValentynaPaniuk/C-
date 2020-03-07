using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class TeamLeader : IWorker
    {
        protected House house = new House();
        protected List<IPart> parts = new List<IPart>();


        public void Work()
        {
           Console.WriteLine(" Team Leader said: The house is built! ");
        }

        public void ShowHouse()
        {
            foreach (var e in parts)
            {
                e.ShowData();
            }

            Console.WriteLine(" Team Leader said: The house is built! ");
        }
    }
}
