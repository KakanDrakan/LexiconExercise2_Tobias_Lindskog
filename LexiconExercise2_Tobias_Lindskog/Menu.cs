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
                    $"3: Repeat the third word");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        isAlive = false;
                        break;
                    case "1":
                        CinemaTicketCost.MainTickedCost();
                        break;


                }
            } while (isAlive);
            
        }
    }
}
