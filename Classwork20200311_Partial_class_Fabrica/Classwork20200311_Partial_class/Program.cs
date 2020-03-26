using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200311_Partial_class
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* 1. Class Factory, містить авто-властивість 
             * string Name, 
             * масив Departments[], 
             * масив Products[], 
             * метод string ReturnString(); 
             
            2. Class Department містить авто-властивість 
             * string Name, масив Employees[], 
             * метод string ReturnString(); 
            
            3. Class Employee містить авто-властивість 
             * string Name, 
             * авто-властивість string Surname, 
             * авто-властивість int Age, 
             * авто-властивість decimal Salary, 
             * метод string ReturnString(); 
            
            4. Class Product містить авто-властивість 
             string Name, 
             авто-властивість int Size, 
             авто-властивість double Price, 
             метод string ReturnString(); 
             
            5. Класи розмістити в окремих файлах з відповідними класами
========================
1. Class Factory - модифікувати і перетворити на partial class. 
2. Описання полів та оголошеня масиву Департаментів зробити в 1й частині (в першому файлі), 
оголошення масиву Products[] та оголошення і реалізацію методу string ReturnString() в 2му. 

 3. Створти 4 partial метода: 
 a)void SetAvgSalary - встановлення для відповідного приватного поля середньої ЗП по підприємству 
 b) void SetTotalSalary - встановлення для відповідного приватного поля сумарної ЗП 
 c)void SetGDP - встановлення для відповідного приватного поля валового доходу на 1го працівника - сума вартості всіх товарів / на кількість працівників 
 d)Void SetEmpCount - встановлення для відповідного поля загальної кількості працюючих 
 
4. Для отримання даних з відповідних приватних полів cтворити відповідні публічні інтерфейси-методи

5.Оголошення часткових методів зробити в 1й частині, а реалізацію виконати в 2частині класу (в іншому файлі) 

6.Зміна структури класу Фабрика не повинна вплинути на описи інших класів 

7.Змінити поле “Ім”я “ для департаменту на readonly, яке повинне ініціалізуватися у параметризованому конструкторі заданим строковим параметром. 
8.Класи розмежовуюься окремими файлами.

             */

            //Product[] products = new Product[3];
            //products[0] = new Product("System block", 1, 22000);
            //products[1] = new Product("Monitor", 1, 8000);
            //products[2] = new Product("Printer", 1, 4500);



            // Console.WriteLine("===================== DEPARTMENTS ===========================");







            Factory myFactory = new Factory("SONY");
            myFactory.ReturnString();
            bool exit = false;
            
            while (!exit)
            {
                
                
                Console.WriteLine("1 - All Salary;\n2 - Average salary;\n3 - Gross income;\n4 - total number of employees;\n5 - Info\n0 - Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            myFactory.SetTotalSalary();
                            Console.WriteLine("\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            myFactory.SetAvgSalary();
                            Console.WriteLine("\n");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            myFactory.SetGDP();
                            Console.WriteLine("\n");
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            myFactory.SetEmpCount();
                            Console.WriteLine("\n");
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            myFactory.ReturnString();
                            Console.WriteLine("\n");
                            break;
                        }
                    case 0:
                        {
                            exit = true;
                            break;
                        }
                  

                }

            }


           
            

            





        }

        



    }
}
