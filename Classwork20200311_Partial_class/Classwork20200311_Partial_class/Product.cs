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

       
        public Product(string name, int size, double price)
        {
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }


        public string ReturnProduct()
        {
            return $"Product name: {this.Name}\t Size: {this.Size}\tPrice: {this.Price}";
        }
    }
}
