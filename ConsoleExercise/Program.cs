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
            Console.Write("Type whatever you want and I'll remove the special characters and reverse it!");
            Console.WriteLine();

            string randomString = Console.ReadLine();

            string cleanString = Regex.Replace(randomString, "[^A-Za-z0-9 ]", "");

            string cleanestString = Regex.Replace(cleanString, " ", "");

            string reverseString = new string(cleanestString.ToCharArray().Reverse().ToArray());

            Console.WriteLine(reverseString);
            Console.ReadLine();

        }
    }
}
'\n'