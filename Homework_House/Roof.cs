using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_House
{
    class Roof : IPart
    {
        public string Part { get; set; } = "-----------------";

        public string Do()
        {
            return this.Part;
        }
    }
}
