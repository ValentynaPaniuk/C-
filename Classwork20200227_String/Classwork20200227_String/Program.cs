using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Classwork20200227_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Вводится строка слов. Вывести слова в обратном порядке.  
             */
            //string s = Console.ReadLine();
            //string reverseS = new string(s.ToArray().Reverse().ToArray());
            //Console.WriteLine(reverseS);

            /* Вставить в заданную позицию строки другую строку*/

            //string a = "My name is ";
            //Console.WriteLine(a);
            //string b = "Valya";
            //Console.WriteLine(b);
            //Console.WriteLine($"Length: {a.Length} ");
            //string aNew = a.Insert(11, b);
            //Console.WriteLine(aNew);

            ///*Найти в строке все заданные последовательности символов и заменить их другой последовательностью. (з клавіатури)  */
            //string d = "I have some questions";
            //bool X = d.Contains("have");
            //Console.WriteLine($"Is text: {X}");
            //d = d.Replace("have", Console.ReadLine());
            //Console.WriteLine(d);

            ///* Дана квадратная матрица, состоящая из букв. 
            // * Найти в ней цепочку букв, составляющую заданное слово.*/
            char[,] str1 = new char[3, 3] { { 'a', 'b', 'c' }, { 'd', 'i', 'f' }, { 'j', 'k', 'l' } };

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str1.GetUpperBound(1) + 1; j++)
                {
                    Console.WriteLine($"{str1[i, j]}");
                }
            }
       




            /* Дана строка слов, разделенных пробелами. 
              Между словами может быть несколько пробелов, в начале и конце строки также могут быть пробелы. 
              Требуется преобразовать строку так, чтобы в ее начале и конце пробелов не было, а слова были разделены одиночным символом "*" (звездочка)   
             */

           


        }
    }
}
