using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200319_Index_Telephone
{
    class Phonebook
    {
        int size;
        int[] phone;
        string[] name;
        string[] date;


        public Phonebook() { }
        public Phonebook(int size)
        {
            Random x = new Random();
            this.size = size;
            this.phone = new int[this.size];
            this.name = new string[this.size];
            this.date = new string[this.size];
            for (int i = 0; i < this.size / 2; i++)
            {
             
               this.phone[i] = x.Next(11111,99999);
                Console.WriteLine($"Phone number {i+1}:  {this.phone[i]}");
              
                Console.WriteLine($"Name {i+1}: ");
              this.name[i] = Console.ReadLine();


                Console.WriteLine($"Date: ");
                this.date[i] = Console.ReadLine();

            }

            

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Phone book: ");
            for (int i = 0; i<phone.Length; i++)
            {
                Console.WriteLine($"Phone: {this.phone[i]} - {this.name[i]}");
            }
        }

        public void AddNewPhone()
        {

            for (int i = (this.size / 2); i< (this.size / 2)+1; i++)
            {

                Console.WriteLine($"Phone number {i + 1}: ");
                this.phone[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Name {i + 1}: ");
                this.name[i] = Console.ReadLine();
                Console.WriteLine($"Date: ");
                this.date[i] = Console.ReadLine();
            }

        }

        public void EditingData()
        {
            Console.WriteLine($"Whose number do you want to change ?: ");
            string name = Console.ReadLine();
            bool exit = false;
            while (!exit)
            {
                for (int i = 0; i < this.size; i++)
                {
                    if (this.name[i] == name)
                    {
                        this.phone[i] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine($"No such name was found");
                        exit = true;
                    }
                }
            }

        }

        public int this[int index]
        {
            get { return this.phone[index]; }
            set { this.phone[index] = value; }
        }

    }
}
