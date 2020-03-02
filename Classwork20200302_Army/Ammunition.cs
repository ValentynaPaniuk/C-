using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Army
{
    class Ammunition : Tank
    {
        /* Боекомплект: 130—150 снарядов 45-мм или 50 снарядов — 76-мм.
             2500—3000 пулемётных патронов*/
        int machine_gun_cartridges;
        public int Machine_gun_cartridges
        {
            get { return machine_gun_cartridges; }
            set
            {
                if (value > 2500 && value < 3000) { machine_gun_cartridges = value; }
                else { Console.WriteLine("Enter correct data"); }
            }
        }


        int shell;
        public int Shell
        {
            get { return shell; }
            set
            {
                if (value == 45)      { shell = 150; }
                else if (value == 76) { shell = 50;}

            }
        }



    }
}
