using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200311_Partial_class
{
    class Department
    {
        /*  2. Class Department містить авто-властивість
              * string Name, 
              * масив Employees[], 
              * метод string ReturnString();*/

        public readonly string Name;
        public Employee [] Arr;
      

        public Department()
        {
            Console.WriteLine($"Enter name of Department: ");
            this.Name = Console.ReadLine();
            Console.WriteLine($"How many people in \"{this.Name}\" department: ");
            int size = int.Parse(Console.ReadLine());
            this.Arr = new Employee[size];
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine($"   Employee N{i+1}=> ");
                this.Arr[i] = new Employee();
            }
            
        }

        
        public string ReturnDepartment()
        {
            Console.WriteLine($"   Department name: {this.Name} ");
            foreach (var e in Arr)
            {
                Console.WriteLine(e.ReturnEmployeer());
              
            }

            return this.Name;
        }

        public decimal ReturnAllDepartmentSalary()
        {
            decimal sum = 0;
            foreach (var e in Arr)
            {                
                sum += e.ReturnSalary();
            }

            return sum;
        }

        public int ReturnNumberEmploeyees()
        {
            return Arr.Length;
        }


    }
}
