using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Classwork20200225_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                C#
                Початковий вклад в банку рівний 1000 грн. 
                Через кожен місяць розмір вкладу збільшується на Р процентів від наявної суми 
                (Р - дійсне число, 0 < P < 25). 
                Значення Р программа повинна отримувати від користувача. 
                По даному Р программа повинна визначити, через скільки місяців розмір вкладу перевищить 1100 грн. 
                та вивести знайдену кількість місяців К (ціле число) та підсумковий розмір вкладу S (дійсне число).  
            */

            int summa = 1000;
            int p;
            int i = 0;
            int month;
            bool exit = false;

            Console.WriteLine("Enter %: ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            month = int.Parse(Console.ReadLine());

            while (i < month)
            {
                summa += (summa * p / 100);
                i++;
                if (summa > 1100 && !exit )
                {
                    Console.WriteLine("Amount exceeded 1100 through: ");
                    Console.WriteLine(i);
                    exit = true;
                }

            }
                        

            Console.WriteLine("Summa new = ");
            Console.WriteLine(summa);
            Console.WriteLine("after ");
            Console.WriteLine(month);
            Console.WriteLine("months");
            Console.WriteLine("=====================================\n");



        }
    }

}
