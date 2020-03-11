using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Intro_OOP
{
    class Department
    {
        /*2. Class Department містить авто-властивість 
             * string Name,
             * масив Employees[], 
             * метод string ReturnString(); */
        public string NameDepartmant { get; private set; } = "NameDepartmant";
        Employee[] employees;

    }
}
