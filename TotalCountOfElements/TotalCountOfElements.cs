using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAgain
{
    class TotalCountOfElements
    {

        //array that displays total count of elements in the array
        static void Main(string[] args)
        {

            string[] movies = { "Elf", "Soul Plane", "Friday", "Friday After Next", "Thor:Ragnorok" };

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);

            }
            Console.WriteLine("\n---------------");
            Console.WriteLine("\n Here are the movies in reverse order for whatever reason:");
            Console.WriteLine("\n ---------------");
            Array.Reverse(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
