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


        public Employee(string Name, int age, decimal salary)
        {
            this.Name = Name;
            this.Age = age;
            this.Salary = salary;
        }

        public string ReturnEmployeer()
        {
            return $"Employee name: {this.Name}\t Age: {this.Age}\t Salary: {this.Salary}";
        }
        
    }

   
}
