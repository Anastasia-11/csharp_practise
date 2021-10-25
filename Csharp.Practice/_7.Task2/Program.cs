using System;

namespace _7.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[] {32L, 'A', "Hey"};
            foreach (var item in arr)
            {
                Console.Write(item);
                Console.Write(' ');
            }

            arr[0] = (long)arr[0] + int.MaxValue;
            arr[2] = arr[2] + " guys!";
            
            foreach (var item in arr)
            {
                Console.Write(item);
                Console.Write(' ');
            }
        }
    }
}