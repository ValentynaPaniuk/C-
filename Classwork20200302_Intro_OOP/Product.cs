using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Intro_OOP
{
    class Product
    {
        /*4. Class Product містить 
             * авто-властивість string Name, 
             * авто-властивість int Size, 
             * авто-властивість double Price, 
             * метод string ReturnString(); */
        public string NameProduct { get; private set; } = "NameProduct";
        public int Size { get; private set; } = 10;
        public double Price {get; private set; } = 50;

               


    }
}
