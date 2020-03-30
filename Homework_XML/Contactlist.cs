using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_XML
{
    class Contactlist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }

        public static Contactlist[] GetAllSContacts()
        {
           
            Console.WriteLine("How many contacts you want to add:");
            int size = int.Parse(Console.ReadLine());
            Contactlist[] contacts = new Contactlist[size];
            for (int i = 0; i < size; i++)
            {
               
                contacts[i] = new Contactlist();
              
                contacts[i].ID = i+1;
                Console.WriteLine($"   ADD CONTACT N: {contacts[i].ID}");
                Console.WriteLine("Enter Name of contact: ");
                contacts[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Birthday of contact: ");
                contacts[i].Birthday= Console.ReadLine();
                Console.WriteLine("Enter Phone of contact: ");
                contacts[i].Phone = Console.ReadLine();
               
            }

            return contacts;
        }
    }
}
