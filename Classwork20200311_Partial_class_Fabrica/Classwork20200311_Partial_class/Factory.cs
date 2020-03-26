using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200311_Partial_class
{
    public partial class Factory
    {
        /* 1. Class Factory, містить авто-властивість 
            * string Name, 
            * масив Departments[], 
            * масив Products[], 
            * метод string ReturnString();
            * 
            1. Class Factory - модифікувати і перетворити на partial class. 
2. Описання полів та оголошеня масиву Департаментів зробити в 1й частині (в першому файлі), */

        public string Name { get; set; }
           
        Department[] Departments;
        

        public Factory() { }
        public Factory(string name)
         {
            this.Name = name;   
            Console.WriteLine($"How many Departments will be in the factory \"{this.Name}\":");
            int x = int.Parse(Console.ReadLine());
            this.Departments = new Department[x];
            for (int i = 0; i < this.Departments.Length; i++)
            {
                Console.WriteLine($"   DEPARTMENT N{i + 1}=> ");
                this.Departments[i] = new Department();
            }
            Console.WriteLine($"How many Products will be in the factory \"{this.Name}\":");
            int y = int.Parse(Console.ReadLine());
            this.Products = new Product[y];
            for (int i = 0; i < this.Products.Length; i++)
            {
                Console.WriteLine($"   PRODUCT N{i + 1}=> ");
                this.Products[i] = new Product();
            }

        }

        public void ShowDep()
        {
            for (int i = 0; i < Departments.Length; i++)
            {
                Departments[i].ReturnDepartment();
            }
        }

        /*
        * 3. Створти 4 partial метода: 
a)void SetAvgSalary - встановлення для відповідного приватного поля середньої ЗП по підприємству 
b) void SetTotalSalary - встановлення для відповідного приватного поля сумарної ЗП 
c)void SetGDP - встановлення для відповідного приватного поля валового доходу на 1го працівника - сума вартості всіх товарів / на кількість працівників 
d)Void SetEmpCount - встановлення для відповідного поля загальної кількості працюючих 
        */

        //5.Оголошення часткових методів зробити в 1й частині
        //public void SetAvgSalary();

        //public void SetTotalSalary();

        //public void SetGDP();

        //public void SetEmpCount();



    }
}
