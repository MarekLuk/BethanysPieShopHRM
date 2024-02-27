using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            //int result = GetSum(a, b);

            int res2 = 0;


            //Console.WriteLine(result);

foreach (var item in args)
            {
               Console.WriteLine(item);
         }

            for (int i = 0; i <10; i++)
            {
                res2 = i;
            }
        }


        //private static int GetSum(int a, int b)
        //{
        //    Console.WriteLine("Returning the sum.");
        //    return a + b;
        //}

    }
}