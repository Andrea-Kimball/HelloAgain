using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAgain
{
    class ArrayIdentifyingNegativeElements
    {

        //array that identifies all negative elements 
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 3, -5, 8, -13, 11 };

            Console.WriteLine("Here are all of the elements of your array");
            for (int i = 0; i < arr.Length; i++)
            { Console.WriteLine(arr[i]); }

            Console.WriteLine("Here are the negative elements of your array:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
