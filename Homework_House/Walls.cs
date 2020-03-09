using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_House
{
    class Walls : IPart
    {
        public string Part { get; set ; } = "|               |\n|               |\n|               |\n|               |\n|               |\n|               |\n";

        public string Do()
        {
            return this.Part;
        }
    }
}
