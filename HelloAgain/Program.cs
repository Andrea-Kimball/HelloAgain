using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAgain
{
  
    class Program
    {
        static void Main1(string[] args)
        {
            string userName;
            int birthYear;
            int currentYear = 2022;

            Console.WriteLine("Please enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0}. What year were you born? ", userName);
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Well, that must make you {0}", currentYear - birthYear);
            Console.ReadKey();

        }
    }
}