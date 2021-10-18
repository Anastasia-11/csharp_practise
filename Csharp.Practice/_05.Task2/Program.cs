using System;

namespace _05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortValue = default;

            object obj = shortValue;

            sbyte sbyteValue = (sbyte)(short)obj;

            Console.WriteLine($"Variable value = {sbyteValue}");
            Console.WriteLine($"Type is {sbyteValue.GetType()}");
        }
    }
}