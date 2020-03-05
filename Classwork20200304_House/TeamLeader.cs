using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class TeamLeader : IWorker
    {
        public void Work()
        {
           Console.WriteLine(" Team Leader said: The house is built! ");
        }
    }
}
