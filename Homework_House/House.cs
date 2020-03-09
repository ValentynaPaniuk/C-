using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_House
{
    class House : IPart
    {
        Basement basement;
        Walls walls;
        Door door;
        Window window;
        Roof roof;



        public string Part { get; set; } = "We have house";

        public string Do()
        {
            return this.Part;
        }

        public void ShowHouse()
        {
            Console.WriteLine($"{basement.Do()}, {walls.Do()}, {door.Do()}, {window.Do()} ,{roof.Do()}");
        }
    }
}
