using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Army 
{
    class Armament : Tank
    {
        /*1 — 45-мм пушка со стабилизатором,
        * 3 пулемёта ДТ,
        * огнемёт для самозащиты или 1 — 76-мм пушка,
        * 3 пулемёта ДТ, огнемёт для самозащиты.
        Каждый 5-й танк должен иметь зенитную установку.*/

        Tank[] tanks;
        public int Gun_with_stabilizer { get; set; } = 45;      //1 — 45-мм пушка со стабилизатором,
        public int Machine_gun_dt { get; set; } = 3;            //3 пулемёта ДТ,
        public int Self_defense_flamethrower { get; set; } = 1; //огнемёт для самозащиты
        public int Gun_76_mm { get; set; } = 1;                 //или 1 — 76-мм пушка,
        int anti_aircraft_installation;
        
        public int Anti_aircraft_installation                    //Каждый 5-й танк должен иметь зенитную установку.*/
        {
            get { return anti_aircraft_installation; }
            set
            {
                for (int i = 0; i < tanks.Length; i++)
                {
                    if (i == 5) { anti_aircraft_installation = 1; }
                    else { anti_aircraft_installation = 0;}
                }
               
            }

        }

       
       







    }
}
