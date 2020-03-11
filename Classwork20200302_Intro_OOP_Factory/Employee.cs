using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Intro_OOP
{
    class Employee
    {/*3. Class Employee містить авто-властивість 
             * string Name, 
             * авто-властивість string Surname, 
             * авто-властивість int Age, 
             * авто-властивість decimal Salary, 
             * метод string ReturnString(); */
        public string NameEmployee { get; private set; } = "NameEmployee";
        public string SurnameEmployee { get; private set; } = "SurnameEmployee";
        public int Age { get; private set; } = 30;
        public decimal Salary { get; private set; } = 3;


    }
}
