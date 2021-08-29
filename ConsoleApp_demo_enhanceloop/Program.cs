using System;

namespace ConsoleApp_demo_enhanceloop
{
 
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr;

            arr = new string[10];
            arr[0] = "aa";
            arr[1] = "bb";
            arr[2] = "cc";

            Console.WriteLine("Elements of the array : ");

            foreach (string val in arr)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();


            /*
            int[] lst = { 23, 34, 45, 56 };
            foreach(int x in lst)
            {
                Console.WriteLine(x);
            }
            */

        }
    }
}
