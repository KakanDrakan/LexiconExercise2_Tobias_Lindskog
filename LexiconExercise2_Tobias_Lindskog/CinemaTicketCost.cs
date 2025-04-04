﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise2_Tobias_Lindskog
{
    public static class CinemaTicketCost
    {
        //Idk could be useful to have
        private const int YOUTH_AGE_MAX = 20;
        private const int YOUTH_PRICE = 80;
        private const int PENSIONER_AGE = 64;
        private const int PENSIONER_PRICE = 90;
        private const int STANDARD_PRICE = 120;
        private const int FREE_AGE_LOW = 5;
        private const int FREE_AGE_HIGH = 100;

        public static void SubMenu()
        {
            Console.WriteLine($"Do you want the cost of an individual person or for a group of peopel?{Environment.NewLine}" +
                    $"1: Cost of one ticket{Environment.NewLine}" +
                    $"2: Total cost for a group of people");
            
            string input = Console.ReadLine();
            bool success = false;
            do
            {
                if (int.TryParse(input, out int choice))
                {
                    if (choice == 1)
                    {
                        success = true;
                        IndividualTicketCost();
                    }
                    else if (choice == 2)
                    {
                        success = true;
                        GroupTicketCost();
                    }
                    else Console.Write("Error: invalid input. Please type 1 or 2:");
                }
                else Console.Write("Error: invalid input. Please type 1 or 2:");

            } while (!success);
        }

        private static void GroupTicketCost()
        {
            int totalCost = 0;
            int numberOfPeople;
            bool success = false;
            Console.Write("Number of people: ");

            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out numberOfPeople))
                {
                    if (numberOfPeople<=0)
                    {
                        Console.WriteLine("That is an invalid amount of people");
                    }
                    else
                    {
                        for (int i = 0; i < numberOfPeople; i++)                        //checking each person if free, then youth, then old and adding price to total
                        {
                            int age = AskAge($"Person {i+1}");
                            if (age < FREE_AGE_LOW || age > FREE_AGE_HIGH) continue; 
                            else if (age < YOUTH_AGE_MAX) totalCost += YOUTH_PRICE;
                            else if (age > PENSIONER_AGE) totalCost += PENSIONER_PRICE;
                            else totalCost += STANDARD_PRICE;
                        }
                        success = true;
                    }

                }
                else Console.Write("Invalid input. Please type the number of people: ");
            } while (!success);

            Console.WriteLine($"Total cost for those {numberOfPeople} people is {totalCost}{Environment.NewLine}");
        }

        private static void IndividualTicketCost()
        {
            string output;

            Console.Write("Age: ");
            int age = AskAge();

            if (age < FREE_AGE_LOW) output = $"Ticket is free for children under {FREE_AGE_LOW}";

            else if (age < YOUTH_AGE_MAX) output = $"Price for youths: {YOUTH_PRICE}kr";

            else if (age > FREE_AGE_HIGH) output = $"Ticket is free for people over {FREE_AGE_HIGH}";

            else if (age > PENSIONER_AGE) output = $"Price for pensioners: {PENSIONER_PRICE}kr";

            else output = $"Standard price: {STANDARD_PRICE}kr";
                
            Console.WriteLine(output);
            Console.WriteLine();
      
        }

        private static int AskAge(string respondent = "")
        {
            int age;
            if (respondent == "") Console.Write("Age: ");
            else Console.Write($"{respondent}'s age: ");
                string input = Console.ReadLine();
            while (!int.TryParse(input, out age))
            {
                Console.Write("Invalid age input. Please type age as a number: ");
                input = Console.ReadLine();
            }
            while (age < 0)
            {
                Console.WriteLine("Age cannot be negative. Please type a positive number: ");
                input = Console.ReadLine();
            }
            return age;
        }
    }
}
