using System;

namespace _05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortValue = 1;

            object obj = shortValue;

            sbyte sbyteValue = Convert.ToSByte(obj);

            Console.WriteLine($"Variable value = {sbyteValue}");
            Console.WriteLine($"Type is {sbyteValue.GetType()}");
        }
    }
}