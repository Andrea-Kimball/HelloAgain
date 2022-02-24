using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DisplaysElementsAlphabetically
    {
        static void Main(string[] args)
        {

            //array that displays the elements in alphabetical order
            
                string[] classroom = new string[6];

                Console.WriteLine("Enter each students name");

                for (int i = 0; i < 6; i++)
                {
                    classroom[i] = Console.ReadLine();
                }

                Console.WriteLine("Here is a list of your students in alphabetical order:");
                Console.WriteLine("\n -----------------------------------");
                Array.Sort(classroom);

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(classroom[i]);
                }
                ;
                Console.ReadKey();

            }
        }
    }

