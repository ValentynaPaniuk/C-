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
            #region
            /* Вводится строка слов. Вывести слова в обратном порядке.*/
            Console.WriteLine(" ==============Exercise 1 =====================");
            Console.WriteLine("Enter text: ");
            string f = Console.ReadLine();
            string reverseS = new string(f.ToArray().Reverse().ToArray());
            Console.WriteLine(reverseS);
            #endregion

            #region
            /* Вставить в заданную позицию строки другую строку*/
            Console.WriteLine(" ==============Exercise 2 =====================");
            string a = "My name is ";
            Console.WriteLine(a);
            string b = "Valya";
            Console.WriteLine(b);
            Console.WriteLine($"Length: {a.Length} ");
            string aNew = a.Insert(11, b);
            Console.WriteLine(aNew);
            #endregion

            #region
            /*Найти в строке все заданные последовательности символов и заменить их другой последовательностью. (з клавіатури)  */
            Console.WriteLine(" ==============Exercise 3 =====================");
            string d = "I have some questions";
            bool X = d.Contains("have");
            Console.WriteLine($"Is text: {X}");
            Console.WriteLine("Enter text: ");
            d = d.Replace("have", Console.ReadLine());
            Console.WriteLine(d);
            #endregion


            #region
            /* Дана квадратная матрица, состоящая из букв. 
              Найти в ней цепочку букв, составляющую заданное слово.*/
            Console.WriteLine(" ==============Exercise 4 =====================");
            char[,] str1 = new char[3, 3] { { 'a', 'b', 'c' },
                                            { 'd', 'i', 'f' },
                                            { 'j', 'k', 'l' } };

            string sumChars = "";

            for (int i = 0; i < str1.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < str1.GetUpperBound(1) + 1; j++)
                {
                    Console.Write("{0}    ", str1[i, j]);
                }
                Console.Write("\n");
            }

            for (int i = 0; i < str1.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < str1.GetUpperBound(1) + 1; j++)
                {
                    str1[i, j] = Convert.ToChar(str1[i, j]);
                    sumChars += str1[i, j];
                }
            }

            Console.Write(sumChars);
            Console.Write("\n");
            Console.WriteLine("Enter the text do You want to find: ");
            string A = Console.ReadLine();

            if (sumChars.Contains(A))
            {
                Console.WriteLine("Finded word: {0}", A);
            }
            else
            {
                Console.WriteLine("Didn't find word: {0}", A);
            }

            #endregion

            #region
            /*Дана строка слов, разделенных пробелами. 
             Между словами может быть несколько пробелов, в начале и конце строки также могут быть пробелы. 
             Требуется преобразовать строку так, чтобы в ее начале и конце пробелов не было, а слова были разделены одиночным символом "*" (звездочка)   
            */
            Console.WriteLine(" ==============Exercise 5 =====================");
            Console.WriteLine("Enter text: ");
            var s = Console.ReadLine();
            Console.WriteLine(System.Text.RegularExpressions.Regex.Replace(s.Trim(), " +", "*"));
            Console.ReadKey();



            #endregion


        }
    }
}
