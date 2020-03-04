using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написати клас, що складається лише з статичних методів (жодного поля в ньому немає (!)) та реалізує роботу з числами. 
                Він містить наступний набір методів:
                Метод swap, що міняє місцями значення двох змінних типу double.
                Метод з змінною кількістю параметрів для обрахунку добутка переданих аргументів.
                Відмітимо також, що для класа заборонено створення екземпляра, тобто заборонений виклик конструкторів. */

            Operation.Swap(2.3, 5.6);
            Operation.Change_integers(5, 8, 7, 6);
            
        }
    }
}
