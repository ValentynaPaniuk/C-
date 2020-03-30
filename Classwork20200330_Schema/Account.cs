using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200330_Schema
{
    class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Date { get; set; }

        public static Account[] GetAllSContacts()
        {

            Console.WriteLine("How many accounts you want to add:");
            int size = int.Parse(Console.ReadLine());
            Account[] contacts = new Account[size];
            for (int i = 0; i < size; i++)
            {
                contacts[i] = new Account();
                contacts[i].ID = i + 1;
                Console.WriteLine($"   ADD CONTACT N: {contacts[i].ID}");
                Console.WriteLine("Enter Name of contact: ");
                contacts[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Login of contact: ");
                contacts[i].Login = Console.ReadLine();
                Console.WriteLine("Enter Password of contact: ");
                contacts[i].Password = Console.ReadLine();
                Console.WriteLine("Enter Date of Create account of contact: ");
                contacts[i].Date = Console.ReadLine();

            }
            return contacts;
        }
    }
}