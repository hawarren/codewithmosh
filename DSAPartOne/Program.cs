using System;

namespace DSAPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // int[] numbers = new int[3];
            int[] numbers = {10,20,30 };
            // numbers[0] = 10;
            // numbers[1] = 20;
            // numbers[2] = 30;
            foreach (var item in numbers){

            Console.WriteLine(item.ToString());
            }
        }
        
    }
}
