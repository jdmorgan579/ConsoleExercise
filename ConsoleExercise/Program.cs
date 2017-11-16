using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            if (args.Length > 0) //Did someone pass in an argument using the command line?
            {
                input = CommandLine.GetInputFromCommandLine(args);
                Console.Write(input);
            }
            else
            {
                Console.WriteLine("Please enter a string!");
            }
            //keep doing what you were doing...
            
            Console.WriteLine();

            string randomString = Console.ReadLine();

            string cleanString = Regex.Replace(randomString, "[^A-Za-z0-9]", "");

            string reverseString = new string(cleanString.Reverse().ToArray());

            Console.WriteLine(reverseString);
            Console.ReadLine();

        }

    }
   
}
'\n'