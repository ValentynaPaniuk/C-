using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Створити узагальнюючий клас, який містить список елементів (List< T >)  * та реалізує роботу з ним,
             включаючи сортування. Клас описати за допомогою узагальнюючих алгоритмів Generics. 
             Сортування реалізувати довільним методом 
             (вибором, бульбашковим тощо).*/

            //List<Part> parts = new List<Part>();
                       
            //parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            //parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            //parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            //parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            //parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            //parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

          
            //Console.WriteLine();
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}

            //// Check the list for part #1734. This calls the IEquatable.Equals method
            //// of the Part class, which checks the PartId for equality.
            //Console.WriteLine("\nContains(\"1734\"): {0}",
            //parts.Contains(new Part { PartId = 1734, PartName = "" }));

            //// Insert a new item at position 2.
            //Console.WriteLine("\nInsert(2, \"1834\")");
            //parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            ////Console.WriteLine();
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}

            //Console.WriteLine("\nParts[3]: {0}", parts[3]);

            //Console.WriteLine("\nRemove(\"1534\")");

            //// This will remove part 1534 even though the PartName is different,
            //// because the Equals method only checks PartId for equality.
            //parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            //Console.WriteLine();
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}
            //Console.WriteLine("\nRemoveAt(3)");
            //// This will remove the part at index 3.
            //parts.RemoveAt(3);

            //Console.WriteLine();
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}


            //// This shows calling the Sort(Comparison(T) overload using 
            //// an anonymous method for the Comparison delegate. 
            //// This method treats null as the lesser of two values.
            //parts.Sort(delegate (Part x, Part y)
            //{
            //    if (x.PartName == null && y.PartName == null) return 0;
            //    else if (x.PartName == null) return -1;
            //    else if (y.PartName == null) return 1;
            //    else return x.PartName.CompareTo(y.PartName);
            //});

            //Console.WriteLine("\nAfter sort by name:");
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}


            /*  2. метод, який дозволяє підрахувати скільки разів кожне слово зустрічається в заданому тексті. 
              Результат записати в колекцію Dictionary <TKey, TValue>.
             */

            char[] delimiters = { ' ', ',', '.' };
            string s = "I love you ! And you, and you, and you you you...";
            string[] words = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            CountWords cw = new CountWords();
            foreach (string i in words)
            {
                cw.AddWord(i);
            }
            cw.PrintStats();
            Console.ReadLine();




        }
    }
}
