using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200311_Partial_class
{
    class Employee
    {
        /*
         *  3. Class Employee містить авто-властивість 
             * string Name, 
             * авто-властивість string Surname, 
             * авто-властивість int Age, 
             * авто-властивість decimal Salary, 
             * метод string ReturnString(); 
         */

        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }


        public Employee()
        {
            Console.WriteLine("Enter employees Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter employees Age: ");
            this.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employees Salary: ");
            this.Salary = decimal.Parse(Console.ReadLine());
        }

        public string ReturnEmployeer()
        {
            return $"Employee name: {this.Name}\t Age: {this.Age}\t Salary: {this.Salary}";
        }


        public decimal ReturnSalary()
        {
            return this.Salary;
        }
        
    }

   
}
