using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork202003_Car
{
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {

            /*Розробити гру "Гонки" з використанням делегатів. 
             * Щоб подивитись опис даного завдання натисніть тут.

В грі використати кілька класів автомобілів (спортивні, легкові, грузові і автобуси). 
Розробити методи і властивості для кожного з оголошених класів. 
Реалізувати гру у вигляді класу, який за допомогою делегатів управляє автомобілями в процесі гри. 

Рекомендації по виконанню роботи: 
Розробити віртуальний клас "Car" (Автомобіль). 
Можна скористатись вже розробленим раніше в уроці 6, тільки допрацювати його. 

В даному класі зібрати всі спільні поля, властивості, методи, наприклад, максимальна швидкість, «збільшити швидкість», «зменшити швидкість». 

Розробити класи автомобілів з конкретною реалізацією конструкторів і методів. 

Створити делегат, який працює з об'єктами створених конкретних класів автомобилів і додати події в класи автомобилів.

Клас гри повинен випадковим чином генерувати склад машин, які приймають участь в гонці і 
за допомогою розроблених делегатів управляти їх параметрами (випадковим чином), наприклад, впливати на швидкість руху.

Гра закінчується, коли якийсь з автомобилів проїхав певну відстань (реалізувати за допомогою подій). 
*/

            Car[] car = new Car[5];
            RandomCar(car, 5);
            foreach (var e in car)
            {
                e.ShowInfo();
                
            }
            Console.WriteLine(" ========================== ");
            for (int i = 0; i<car.Length; i++)
            {
                Console.WriteLine($"The car N{i+1}: ");
                car[i].ShowInfo();
                Menu(car[i]);

            }



        }

         public static void RandomCar(Car[]car, int SIZE)
           {
            Console.WriteLine(" ==== CAR ARRAY: ======== ");
            Random x = new Random();
            for (int i=0; i<car.Length; i++)
            {
                switch (x.Next(1, 4))
                {
                    case 1: car[i] = new Ferrari("Ferrary", 120, 300, 8000);
                        break;
                    case 2: car[i] = new Mercedes("Mercedes", 60, 200, 10);
                        break;
                    case 3: car[i] = new Neoplan("Neoplan", 80, 160, 26);
                        break;
                    case 4: car[i] = new Toyota("Toyota", 120, 240, "sedan");
                        break;
                    default:
                        break;
                }

            }
            
        }

        public static void Menu(Car car)
        {
            int choice = 0;
            bool exit = false;
           
            while (!exit)
            {
               Console.Write("1 - Start\n2 - Accelerate\n3 - Stop\n4 - Break\n5 - Refuel\n6 - Repair\n7 - Turn left\n8 - Turn right\n8 - Wash car\n9 - СhangeTire\n0 - Exit\nYour choice: \n");
               choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: car.RegisterMsg(car.Start);
                        Console.ReadLine();
                        break;
                    case 2: car.RegisterMsg(car.Accelerate);
                        Console.ReadLine();
                        break;
                    case 3: car.RegisterMsg(FullStop);
                        Console.ReadLine();
                        break;
                    case 4: car.RegisterMsg(Brake);
                        Console.ReadLine();
                        break;
                    case 5: car.RegisterMsg(Refuel);
                        break;
                    case 6: car.RegisterMsg(Repair);
                        Console.ReadLine();
                        break;
                    case 7: car.RegisterMsg(TurnLeft);
                        Console.ReadLine();
                        break;
                    case 8: car.RegisterMsg(TurnRight);
                        Console.ReadLine();
                        break;
                    case 9:
                        car.RegisterMsg(СhangeTire);
                        Console.ReadLine();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        break;
                }
           

            }
        }



        private static void FullStop()
        {
            Console.WriteLine("fullStop working ...");
            car.Stop(30);
        }
        private static void Brake()
        {
            Console.WriteLine("brake working ...");
            car.Break(40);
        }

        private static void Refuel()
        {
            Console.WriteLine($"refueled");
        }

        private static void Repair()
        {
            Console.WriteLine($"repaired");
        }

        private static void TurnLeft()
        {
            Console.WriteLine($" turned to the left");
        }

        private static void TurnRight()
        {
            Console.WriteLine($"turned to the right");
        }

        private static void WashCar()
        {
            Console.WriteLine($"washed");
        }

        private static void СhangeTire()
        {
            Console.WriteLine($"the tires were changed");
        }

    }
}
