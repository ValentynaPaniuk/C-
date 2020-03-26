using System;

namespace _08._Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phone = new PhoneBook();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Show phonebook\n2. Add new phonenumber\n3. Edit phonenumber\n4. Delete phonenumber\n5. Insert by position\n0. Exit");
                Console.Write("Your choise: ");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        phone.ShowPhoneBook();
                        break;
                    case 2:
                        phone.AddNewNumber();
                        break;
                    case 3:
                        phone.EditNumber();
                        break;
                    case 4:
                        phone.DeleteNumber();
                        break;
                    case 5:
                        EnterNumber(phone);
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            }
        }

        static void EnterNumber(PhoneBook phoneBook)
        {
            int position;

            while (true)
            {
                Console.Write("Enter position(1 - 100): ");
                try
                {
                    position = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                while (true)
                {
                    string tmpNumber = null;

                    if (phoneBook.EnteringNumber(ref tmpNumber).Count > 0)
                    {
                        phoneBook[position] = tmpNumber;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not correct. Try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}