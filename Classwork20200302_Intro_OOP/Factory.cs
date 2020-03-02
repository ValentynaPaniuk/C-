using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Intro_OOP
{
    class Factory
    {
        /*Class Factory, містить 
             * авто-властивість string Name, 
             * масив Departments[], 
             * масив Products[], 
             * метод string ReturnString(); */
        public string NameFactory { get; private set; } = "NameFactory";
        Department[] departments;
    }
}
