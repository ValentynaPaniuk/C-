using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _08._Indexes
{
    class PhoneBook
    {
        string[] PhoneNumber = new string[100];
        public PhoneBook()
        {

            Random rand = new Random();

            for (int i = 0; i < PhoneNumber.Length; i++)
            {
                if (i >= PhoneNumber.Length / 2)
                {
                    this.PhoneNumber[i] = null;
                }
                else
                {
                    this.PhoneNumber[i] = "0" + rand.Next(10, 99) + "-" + rand.Next(100, 999) + "-" + rand.Next(1000, 9999);
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return this.PhoneNumber[index];
            }
            set
            {
                this.PhoneNumber[index] = value;
            }
        }

        public MatchCollection EnteringNumber(ref string tmpNumber)
        {
            Console.Write("Enter number(format: XXX-XXX-XXXX): ");
            tmpNumber = Console.ReadLine();
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");
            MatchCollection matches = regex.Matches(tmpNumber);
            return matches;
        }

        public void ShowPhoneBook()
        {
            while (true)
            {
                try
                {
                    Console.Write("Number of rooms to be displayed per time: ");
                    int numbers = int.Parse(Console.ReadLine());

                    int counter = 1;
                    for (int i = 1; i < this.PhoneNumber.Length + 1; i++)
                    {
                        bool exit = false;
                        Console.WriteLine($"{i}. {this.PhoneNumber[i - 1]}");
                        if (i % numbers == 0)
                        {
                            Console.WriteLine($"\nPage: {counter}/{this.PhoneNumber.Length / numbers}");
                            Console.WriteLine($"\n1. Next page\n2. Prev page\n0. Back");
                            int choise = int.Parse(Console.ReadLine());

                            switch (choise)
                            {
                                case 0:
                                    exit = true;
                                    break;
                                case 1:
                                    Console.Clear();

                                    if (counter >= this.PhoneNumber.Length / numbers)
                                    {
                                        Console.WriteLine("You are on the last page.");
                                        i -= numbers;
                                    }
                                    else
                                    {
                                        counter++;
                                    }
                                    continue;
                                case 2:
                                    Console.Clear();
                                    if (i < (numbers * 2))
                                    {
                                        Console.WriteLine("You are on the homepage.");
                                        i -= numbers;
                                    }
                                    else
                                    {
                                        i -= (numbers * 2);
                                        counter--;
                                    }
                                    continue;
                                default:
                                    if (counter == 1)
                                    {
                                        i = 1;
                                    }
                                    Console.Clear();
                                    Console.WriteLine("Incorrect value. Try again.");
                                    continue;
                            }
                        }
                        if (exit)
                        {
                            break;
                        }
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void AddNewNumber()
        {
            bool checkExist = false;

            for (int i = 0; i < this.PhoneNumber.Length; i++)
            {
                if (this.PhoneNumber[i] == null && !checkExist)
                {
                    checkExist = true;
                    bool exit = false;
                    while (!exit)
                    {
                        string tmpNumber = null;

                        if (EnteringNumber(ref tmpNumber).Count > 0)
                        {
                            this.PhoneNumber[i] = tmpNumber;
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Not correct. Try again.");
                        }
                    }
                    break;
                }

                if (!checkExist && i == this.PhoneNumber.Length - 1)
                {
                    Console.Clear();
                    Console.WriteLine("There is no free space in phone book.");
                    break;
                }
            }
        }

        public void DeleteNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter index for delete number: ");

                    int index = int.Parse(Console.ReadLine());

                    if (this.PhoneNumber[index] == null)
                    {
                        Console.WriteLine("This number is already deleted.");
                        break;

                    }
                    else
                    {
                        this.PhoneNumber[index] = null;
                        Console.WriteLine("Deleted.");
                        break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("You went beyond the array.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void EditNumber()
        {

            int index;
            while (true)
            {
                try
                {
                    Console.Write("Enter index for edit: ");
                    index = int.Parse(Console.ReadLine());

                    bool exit = false;
                    while (!exit)
                    {
                        string tmpNumber = null;

                        if (EnteringNumber(ref tmpNumber).Count > 0)
                        {
                            this.PhoneNumber[index] = tmpNumber;
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Not correct. Try again.");
                        }
                    }

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a value.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("You went beyond the array.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}