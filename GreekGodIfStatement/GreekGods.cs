using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreekGodIfStatement
{
    class GreekGods
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter the name of any Greek god");
            userInput = Console.ReadLine();
            if (userInput.ToUpper() == "Zeus".ToUpper())
            {
                Console.WriteLine("You have chosen Zeus, the god of the sky. Good choice!");
            }
            else if(userInput.ToUpper() == "Hera".ToUpper())
            {
                Console.WriteLine("While technically a god(dess), Hera, is an excellent choice. She is the goddess of marriage, mothers and families");
            }
            else if (userInput.ToUpper() == "Poseidon".ToUpper())
            {
                Console.WriteLine("You have chosen the god of the sea. awesome choice!");
            }
            else if(userInput.ToUpper() == "Hades".ToUpper())
            {
                Console.WriteLine("You have chosen the god of the underworld. Wonderful choice!");
            }
            else
            {
                Console.WriteLine("Im not familiar with that Greek god. Check back later to see if theyve been added");
            }

            Console.ReadKey();
        }
    }
}
