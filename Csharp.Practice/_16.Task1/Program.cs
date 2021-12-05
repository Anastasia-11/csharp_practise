using System;
using _16.Task1.Models;
using _16.Task1.Extensions;

class Program
{
    public static void Main(string[] args)
    {
        UniqueItem item1 = new();
        UniqueItem item2= new();
        UniqueItem item3 = new();
        
        Console.WriteLine(item1.ItemId);
        Console.WriteLine(item2.ItemId);
        Console.WriteLine(item3.ItemId);
        
        UniqueItem item4 = new(10);
        UniqueItem item5= new();
        UniqueItem item6 = new();
        
        Console.WriteLine(item4.ItemId);
        Console.WriteLine(item5.ItemId);
        Console.WriteLine(item6.ItemId);

        string str = "Hello World!";
        Console.WriteLine(str.Modify());
    }
}