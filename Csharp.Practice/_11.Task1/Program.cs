﻿using System;
using System.Collections.Generic;
using _11.Task1.Models;

namespace _11.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string model, manufacturer;
            double mileage, volume, power;

            List<Motorcycle> list = new List<Motorcycle>();
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter model:");
                model = Console.ReadLine();
                Console.WriteLine("Enter manufacturer:");
                manufacturer = Console.ReadLine();
                Console.WriteLine("Enter mileage:");
                mileage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter volume:");
                volume = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter power:");
                power = Convert.ToDouble(Console.ReadLine());
                
                list.Add(new Motorcycle(model, manufacturer, mileage, new Motorcycle.Engine(volume, power)));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}Мотоцикл(Производитель): \"{list[i].Manufacturer}\", Модель: {list[i].Model}, Идентификатор: {list[i].Guid}, Год: {list[i].ReleaseYear}");
                Console.WriteLine($"{i + 1}.1 Двигатель(Объем): {list[i].MotoEngine.Volume}, Мощность: {list[i].MotoEngine.Power}");
            }
            
        }
    }
}