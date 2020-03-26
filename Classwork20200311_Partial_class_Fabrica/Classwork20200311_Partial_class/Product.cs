using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200311_Partial_class
{
    class Product
    {
        /* 4. Class Product містить авто-властивість 
             string Name, 
             авто-властивість int Size, 
             авто-властивість double Price, 
             метод string ReturnString(); 
         */
        string Name { get; set; }
        int Size { get; set; }
        double Price { get; set; }

       
        public Product()
        {
            Console.WriteLine($"Enter Name of Product: ");
            this.Name = Console.ReadLine();
            Console.WriteLine($"Enter Size of Product: ");
            this.Size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Price of Product: ");
            this.Price = double.Parse(Console.ReadLine());
        }


        public string ReturnProduct()
        {

            return $"Product name: {this.Name}\t Size: {this.Size}\tPrice: {this.Price}";
        }

        public double ReturnValueGoods()
        {
            return this.Price * this.Size;
        }
    }
}
