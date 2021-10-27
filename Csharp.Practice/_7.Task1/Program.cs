using System;

namespace _7.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] emptyArray = new int[0];
            foreach (var i in emptyArray)
            {
                Console.WriteLine(i); // will not print anything
            }
        }
    }
}