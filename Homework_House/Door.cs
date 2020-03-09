using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_House
{
    class Door : IPart
    {
        public string Part { get ; set; } = "===\n| |             |\n| |             |\n===             |";

        public string Do()
        {
            return this.Part;
        }
    }
}
