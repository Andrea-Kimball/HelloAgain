using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating a dictionary
            Dictionary<int, string> classroom = new Dictionary<int, string>();
            {
                classroom.Add(1, "Anne");
                classroom.Add(2, "Chuck");
                classroom.Add(3, "Billy");
                classroom.Add(4, "Mandy");
                classroom.Add(5, "Claire");

            };

            //calling a value from the dictionary using the key
            int userInput;
            Console.WriteLine("Please enter a student ID");
            userInput = Convert.ToInt32(Console.ReadLine());

            string value;
            bool hasValue = classroom.TryGetValue(userInput, out value);
            if (!hasValue)
            {
                Console.WriteLine("That student ID could not be found");

            }
            else 
            {
                Console.WriteLine("student ID {0} belongs to: {1}", userInput, classroom[userInput]);
            }

            

            

            Console.ReadKey();

        }
    }
}

