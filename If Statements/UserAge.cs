using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class UserAge
    {
        static void Main(string[] args)
        {
            
            int userAge;
            Console.WriteLine("Please enter your age");
                userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge <=0 || userAge >=100)
            {
                Console.WriteLine("Please enter a valid age");
            }
            else if (userAge >0 || userAge <18)
            {
                Console.WriteLine("You must be 18 or older");
            }
            else
            {
                Console.WriteLine("Your entry could not be recongnized. Please try again");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
