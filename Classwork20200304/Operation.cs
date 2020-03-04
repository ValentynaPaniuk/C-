using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304
{
    static class Operation
    {
        /*Написати клас, що складається лише з статичних методів (жодного поля в ньому немає (!)) та реалізує роботу з числами. 
               Він містить наступний набір методів:
               Метод swap, що міняє місцями значення двох змінних типу double.
               Метод з змінною кількістю параметрів для обрахунку добутка переданих аргументів.
               Відмітимо також, що для класа заборонено створення екземпляра, тобто заборонений виклик конструкторів. */



        // Метод swap, що міняє місцями значення двох змінних типу double.
        public static void Swap(double a, double b)
        {
            Console.WriteLine($"A: {a}\t B: { b}");
            double tmp = 0;
            tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"A after: {a}\t B after: { b}");
        }

        // Метод з змінною кількістю параметрів для обрахунку добутка переданих аргументів.
        public static void Change_integers(params int[] integers)
        {
            int result = 0;
            Console.WriteLine("=================================================\n");
            for (int i = 0; i < integers.Length; i++)
            {
                Console.Write(integers[i]+" ");
            }
            Console.WriteLine("\n=================================================");
          
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }

    }
}
