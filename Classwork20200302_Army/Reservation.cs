using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Army
{
    class Reservation : Tank
    {
        /*Бронирование: 
           Лобовая броня — 25 мм, 
           коническая башня — 20 мм, 
           бортовая броня и корма — 13 мм 16 мм, 
           крыша и дно — 10 мм.*/

        public int Frontal_armor { get; set; } = 25;
        public int Conical_tower { get; set; } = 20;
        public int Side_armor { get; set; } = 13;
        public int Feed { get; set; } = 16;
        public int Roof { get; set; } = 10;
        public int Bottom { get; set; } = 10;

    }
}
