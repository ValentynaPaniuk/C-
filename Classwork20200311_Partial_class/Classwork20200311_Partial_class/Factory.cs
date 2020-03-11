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

        string Name { get; set; }
        Department[] Departments;

        public Factory(string name, Department[] departments, Product[] products)
        {
            this.Name = name;
            
        }


        /*
         * 3. Створти 4 partial метода: 
 a)void SetAvgSalary - встановлення для відповідного приватного поля середньої ЗП по підприємству 
 b) void SetTotalSalary - встановлення для відповідного приватного поля сумарної ЗП 
 c)void SetGDP - встановлення для відповідного приватного поля валового доходу на 1го працівника - сума вартості всіх товарів / на кількість працівників 
 d)Void SetEmpCount - встановлення для відповідного поля загальної кількості працюючих 
         */

        //5.Оголошення часткових методів зробити в 1й частині
        partial void SetAvgSalary();

        partial void SetTotalSalary();

        partial void SetGDP();

        partial void SetEmpCount();



    }
}
