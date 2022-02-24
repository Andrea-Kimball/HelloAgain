using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAgain
{
    class ArraySum
    {

        //array that finds the sum of elements
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 3, -5, 8, -13, 11 };
            Console.WriteLine("Here are all of the elements of your array");

            int sum = arr.Sum();
            int max = arr.Max();
            int min = arr.Min();
            for(int i=0; i < arr.Length; i++) 
            {
                 Console.WriteLine(arr[i]); 
            }
           
            Console.WriteLine("Here is the sum of the elements of your array: \t {0}", arr[sum]);
            //Console.WriteLine("The max number in your array is:\t{0}. The smallest number is:\t{1}",arr[max], arr[min]);



            //Console.WriteLine("\n---------------");
            //Console.WriteLine("Here is the total movie count in this array");
            //Console.WriteLine("\n---------------");
            //int movieSum = Array
            //for(int i = 0; i<movies.Length; i++)
            //{
            //    Console.WriteLine(movieSum);
            //}
            Console.ReadKey();
        }



        
    }
}
