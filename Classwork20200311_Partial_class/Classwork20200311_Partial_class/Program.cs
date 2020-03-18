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

            Product[] products = new Product[3];
            products[0] = new Product("bread", 1, 13);
            products[1] = new Product("water", 2, 24);
            products[2] = new Product("sugar", 1, 18);
       
                        
            Employee[] employeer_department_one = new Employee[3];
            employeer_department_one[0] = new Employee("Victor", 22, 3500);
            employeer_department_one[1] = new Employee("Slavik", 19, 3400);
            employeer_department_one[2] = new Employee("Anton", 22, 3600);
            

            Employee[] employeer_department_two = new Employee[3];
            employeer_department_two[0] = new Employee("Andriy", 28, 3500);
            employeer_department_two[1] = new Employee("Petro", 19, 3400);
            employeer_department_two[2] = new Employee("Kira", 22, 3600);


            Department[] departments = new Department[2];

            Console.WriteLine("===================== DEPARTMENTS ===========================");
            departments[0] = new Department("One department", employeer_department_one);
            departments[1] = new Department("Two department", employeer_department_two);

            Department one = new Department("One Department", employeer_department_one);
            Console.WriteLine(one.ReturnDepartment());
            Department two = new Department("Two Department", employeer_department_two);
            Console.WriteLine(two.ReturnDepartment());

            Department[] allDepartments = new Department[2];
            allDepartments[0] = one;
            allDepartments[1] = two;
            Console.WriteLine("===================== DEPARTMENTS ===========================");
            Console.WriteLine("\n");
            
            Factory myFactory = new Factory ("Factory new", allDepartments, products);
            myFactory.ReturnString();




        }
    }
}
