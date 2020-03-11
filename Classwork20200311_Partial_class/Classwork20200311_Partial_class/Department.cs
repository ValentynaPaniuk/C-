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

        readonly string Name;
        Employee [] Arr;

        public Department(string name, Employee []arr)
        {
            this.Name = name;
            this.Arr = arr;

        }


        public void ShowInfo()
        {
            foreach (var e in Arr)
            {
                Console.WriteLine(e.ReturnEmployeer());
            }
        }
        public string ReturnDepartment()
        {
            Console.WriteLine($"Department name {this.Name}: ");
            foreach (var e in Arr)
            {
                Console.WriteLine(e.ReturnEmployeer());
            }

            return this.Name;
        }

    }
}
