using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200311_Partial_class
{
    public partial class Factory
    {
        /*оголошення масиву Products[] та оголошення і реалізацію методу string ReturnString() в 2му.*/
        Product[] Products;


        public string ReturnString()
        {
            Console.WriteLine($" ============== FACTORY NAME: {this.Name} =======================");

            Console.WriteLine($"Products on the factory \"{this.Name}\":");
            Console.WriteLine($"===========================================================");
            foreach (var e in Products)
            {
                Console.WriteLine(e.ReturnProduct());
            }
            Console.WriteLine($"===========================================================");
            Console.WriteLine("\n");
            Console.WriteLine($"===========================================================");
            Console.WriteLine($"Department on the factory \"{this.Name}\":");
            Console.WriteLine($"===========================================================");

            foreach (var e in Departments)
            {
                Console.WriteLine(e.ReturnDepartment());
            }
            Console.WriteLine($"===========================================================");

            return $"Factory name: {this.Name}";

        }

        //5.Оголошення часткових методів зробити в 1й частині, а реалізацію виконати в 2частині класу (в іншому файлі) 
        public void SetAvgSalary() //встановлення для відповідного приватного поля середньої ЗП по підприємству 
        {
            decimal sum = 0;
            foreach (var e in Departments)
            {
                sum += e.ReturnAllDepartmentSalary();
            }

           
            int num = 0;
            foreach (var e in Departments)
            {
                num += e.ReturnNumberEmploeyees();

            }

            Console.WriteLine($"ALL SALARY = {sum}");
            Console.WriteLine($"EMPLOYEERS = {num}");

            decimal Avarage = sum / num;
            Console.WriteLine($"Avarage salary = {Avarage}");
        }
        public void SetTotalSalary() //встановлення для відповідного приватного поля сумарної ЗП 
        {
            decimal sumFabricaSalary = 0;
            foreach (var e in Departments)
            {
               sumFabricaSalary += e.ReturnAllDepartmentSalary();
            }
            Console.WriteLine($"All salary = {sumFabricaSalary}");

          
        }
        public void SetGDP() //встановлення для відповідного приватного поля валового доходу на 1го працівника - сума вартості всіх товарів / на кількість працівників 
        {
            double totalValueGoods = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                totalValueGoods += Products[i].ReturnValueGoods();
            }

            int number = 0;
            foreach (var e in Departments)
            {
                number += e.ReturnNumberEmploeyees();

            }

            double grossIncome = totalValueGoods / number;
            Console.WriteLine($"Gross income:  {grossIncome}");
        }
        public void SetEmpCount()//встановлення для відповідного поля загальної кількості працюючих 
        {
            Console.WriteLine($"All employees in the factory \"{this.Name}\": ");
            int number = 0;
            foreach (var e in Departments)
            {
                number += e.ReturnNumberEmploeyees();

            }
            Console.WriteLine($"{number}");
           
        } 


    }
}
