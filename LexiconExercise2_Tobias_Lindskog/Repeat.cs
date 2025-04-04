using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise2_Tobias_Lindskog
{
    public class Repeat
    {
        public static void Repeat10Times() 
        {
            Console.Write("Type what should be repeated: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}. {input}");
                if (i!=9) Console.Write(", ");
            }
            Console.WriteLine();
        }

        public static void RepeatThirdWord()
        {
            bool success = false;
            Console.Write("Type a sentence with at least three words: ");
            do
            {
                string[] inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                if(inputs.Length>2) 
                {
                    Console.WriteLine(inputs[2]);
                    Console.WriteLine();
                    success = true; 
                }
                else Console.WriteLine("You need to type a sentence with at least three words");

            } while (!success);
        }
    }
}
