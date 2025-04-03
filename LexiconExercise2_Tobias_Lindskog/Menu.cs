using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise2_Tobias_Lindskog
{
    public static class Menu
    {
        public static void MainMenu() 
        {
            bool isAlive = true;
            do
            {
                Console.WriteLine("You're in the main menu. Navigate by typing numbers:");
                Console.WriteLine($"0. Quit application {Environment.NewLine}" +
                    $"1. Cinema ticket price {Environment.NewLine}" +
                    $"2: Repeat 10 times {Environment.NewLine}" +
                    $"3: Repeat the third word {Environment.NewLine}" +
                    $"4: Clear console");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        isAlive = false;
                        break;
                    case "1":
                        CinemaTicketCost.MainTicketCost();
                        break;
                    case "2":
                        Repeat.Repeat10Times();
                        break;
                    case "3":
                        Repeat.RepeatThirdWord();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;


                }
            } while (isAlive);
            
        }
    }
}
