using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_House
{
    interface IPart
    {
        string Part { get; set; }
        string Do();
    }
}
