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
            string randomString = "kd$2 23re034()9";

            string cleanString = Regex.Replace(randomString, "[^A-Za-z0-9 ]", "");

            string cleanestString = Regex.Replace(cleanString, " ", "");

            string reverseString = new string(cleanestString.ToCharArray().Reverse().ToArray());

            Console.WriteLine(reverseString);
            Console.ReadLine();

        }
    }
}
'\n'