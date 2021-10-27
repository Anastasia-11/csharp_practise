using System;
using System.Linq;

namespace _7.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 133;
            int[] arr = new int[size];
            Random random = new Random();
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }

            int max = 0, index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    index = i;
                }
            }

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"At position: {index}");
            foreach (var item in arr)
            {
                Console.Write(item);
                Console.Write(' ');
            }
        }
    }
}