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
            return $"Factory name: {this.Name}";
        }

        //5.Оголошення часткових методів зробити в 1й частині, а реалізацію виконати в 2частині класу (в іншому файлі) 
        partial void SetAvgSalary() //встановлення для відповідного приватного поля середньої ЗП по підприємству 
        {

        }
        partial void SetTotalSalary(); //встановлення для відповідного приватного поля сумарної ЗП 
        partial void SetGDP(); //встановлення для відповідного приватного поля валового доходу на 1го працівника - сума вартості всіх товарів / на кількість працівників 
        partial void SetEmpCount()//встановлення для відповідного поля загальної кількості працюючих 
        {
            Console.WriteLine($"Enter the number of employees in the department {this.Name}: ");
            int count = int.Parse(Console.ReadLine());

        } 


    }
}
