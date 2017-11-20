using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = GetInput(args);
            var cleanString = Regex.Replace(input, "[^A-Za-z0-9]", "");
            var reverseString = new string(cleanString.Reverse().ToArray());

            Console.WriteLine(reverseString);
            Console.ReadLine();
        }

        public static string GetInput(string[] args)
        {
            string input; 
            if (args.Length > 0)
            {
                input = args[0];
            }
            else
            {
                Console.WriteLine("Please enter a string!");
                input = Console.ReadLine();
            }

            return input;
        }
    }
   
}