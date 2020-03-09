using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_House
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IPart> parts = new List<IPart>();

            parts.Add(new House());
            parts.Add(new Roof());
            parts.Add(new Walls());
            parts.Add(new Window());
            parts.Add(new Door());
            parts.Add(new Basement());

            foreach (var e in parts)
            {
                Console.WriteLine(e.Do());
            }


            Console.ReadLine();
        }
    }
}
