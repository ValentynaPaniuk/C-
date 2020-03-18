using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200312_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. За допомогю мехінізмів наслідування та поліморфізму реалізувати ієрархію наслідування наступних “створінь”:
a) Створіння - абстрактний базовий клас

b) Тварина - клас який реалізовує базовий функціонал, та дозволяє перевизначити свої методи класам-нащадкам за допомогою віртуальних методів

c) Класи Рептилія, Савець, Пташка, Риба - класи нащадки, що реалізують повну функціональність вказаного типу тварини

d) Класи Ведмідь, Жаба, Дельфін, Карп, Орел - класи нащадки, остаточні в дереві наслідування
            //Ведмідь, Bear,    =====>>> Савець, Owl        ====>>>   Бігаючий, Running
            //Жаба,  Frog,      =====>>> Рептилія, Reptile, ====>>>   Плаваюйчий, Floating, Повзаючий, Crawling
            //Дельфін,  Dolphin,=====>>> Савець, Owl        ====>>>   Плаваюйчий, Floating
            //Карп,   Carp      =====>>> Риба, Fish         ====>>>   Плаваюйчий, Floating
            //Орел, Eagle       =====>>> Пташка, Bird       ====>>>   Літаючий, Flying
            

e) Інтерфейси розширюють функціональність тварин, наділяючи їх певними здатностями

            2. Створити “зоопарк” куди помістити не менше одного екземпляру
кожного з дочірніх класів
3. Провести перекличку по “зоопарку” перевіривши повну
функціональність кожної з присутньої тварини
4. При кожному етапі наслідування, клас нащадок розширює
функціональність батьківського клас не менш ніж на 2
властивості/метода або перевизначать такі з батьківського класа
             */
           



            Console.WriteLine($" ======= Bear ==========");
            var bear = new Bear("Bear");
            bear.Live();
            bear.Move();
            bear.Eating();
            bear.Sleep();
            bear.Breathe();
            bear.Wool();

            Console.WriteLine($" ======= Frog ==========");
            var frog = new Frog("Frog");
            frog.Live();
            frog.Move();
            frog.ColdBlood();

            Console.WriteLine($" ======= Dolphin ==========");
            var dolphin = new Dolphin("Dolphin");
            dolphin.Live();
            dolphin.Move();
            dolphin.Breathe();
        
            Console.WriteLine($" ======= Carp ==========");
            var carp = new Carp("Carp");
            carp.Live();
            carp.Move();
            carp.Breathe();

            Console.WriteLine($" ======= Eagle ==========");
            var eagle = new Eagle("Eagle");
            eagle.Live();
            eagle.Move();
            eagle.Feathers();

            Console.WriteLine($" ======= OUR ZOO ==========");
            List<Animal> zoo = new List<Animal>();
            zoo.Add(bear);
            zoo.Add(frog);
            zoo.Add(dolphin);
            zoo.Add(carp);
            zoo.Add(eagle);

            List<Savetz> savetzs = new List<Savetz>();
            foreach (var e in zoo)
            {
                e.ShowInfo();

                Savetz newSavetz = e as Savetz;
                if (newSavetz is Savetz)
                {
                    savetzs.Add(newSavetz);
                }

               
            }
            Console.WriteLine($" =========================");

            Console.WriteLine("==== SAVETZS =====");
            foreach (var e in savetzs)
            {
                e.ShowInfo();
                e.Sleep();
                e.Wool();
                
            }

        }
    }
}
