using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var prices = new Dictionary<string, double>
        {
            {"Premiere", 12},
            {"Normal", 7.5},
            {"Discount", 5}
        };

        string ticketType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double income = rows * columns * prices[ticketType];
        Console.WriteLine($"{income:f2} leva");
    }
}