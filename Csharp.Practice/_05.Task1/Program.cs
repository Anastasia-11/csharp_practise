using System;

namespace _05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = DateTime.Now.TimeOfDay.Hours switch
            {
                var hour when (hour >= 9 && hour < 12) => "Good morning, guys",
                var hour when (hour >= 12 && hour < 15) => "Good day, guys",
                var hour when (hour >= 15 && hour < 22) => "Good evening, guys",
                _ => "It's night"
            };
            Console.WriteLine(message);
        }
    }
}