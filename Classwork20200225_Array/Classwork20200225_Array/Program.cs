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
            Console.WriteLine(" *** Exercise 1 ***");
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
                if (summa > 1100 && !exit)
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



            /*
             C#
             Даний одновимірний цілочисельний масив, дані для якого вводяться користувачем. 
             Перетворити даний масив таким чином, щоб спочатку йшли всі додатні елементи, 
             а потім від'ємні без зміни основного порядку. 
             */
            Console.WriteLine(" *** Exercise 2 ***");
            Console.WriteLine("How many elements will we add to the array?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("===================================================");
            int[] array = new int[x];
            
            for (int i = 0; i<array.Length; i++)
            {
               array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" *** Exercise 2 ***");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
                  
            int[] array_plus = array.Where((num, index) => num >= 0).ToArray();
            int[] array_min = array.Where((num, index) => num < 0).ToArray();

            Console.WriteLine("Array PLUS :");
            for (int i = 0; i < array_plus.Length; i++)
            {
                Console.WriteLine($"array_plus[{i}] = {array_plus[i]}");
            }
            Console.WriteLine("Array MIN :");
            for (int i = 0; i < array_min.Length; i++)
            {
                Console.WriteLine($"array_min[{i}] = {array_min[i]}");
            }

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array_plus.Length)
                {
                    array[i] = array_plus[i];
                }
                else
                {
                    array[i] = array_min[j];
                    j++;
                }
               
            }

            Console.WriteLine(" ========== >>>>>    Array SORTING :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }


        }
    }

}
