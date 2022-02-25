using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, x;
            int i;
            Console.WriteLine();
            total = 0;
            i = 1;
            while (i <= 4)
            {
                Console.WriteLine("Add your next number");
                x = Convert.ToInt32(Console.ReadLine());
                total = total + x;
                i++;
            }
            Console.WriteLine("Your total is:\n***************\n {0}", total);
            Console.ReadKey();
        }
    }
}
