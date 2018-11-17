using System;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        if(budget <= 100)
        {
            double percent = season == "winter" ? 0.7 : 0.3;
            string place = season == "winter" ? "Hotel" : "Camp";
            double price = Math.Round(budget * percent, 2);
            Console.WriteLine("Somewhere in Bulgaria");
            Console.WriteLine($"{place} - {price:f2}");
        }
        else if(budget <= 1000)
        {
            double percent = season == "winter" ? 0.8 : 0.4;
            string place = season == "winter" ? "Hotel" : "Camp";
            double price = Math.Round(budget * percent, 2);
            Console.WriteLine("Somewhere in Balkans");
            Console.WriteLine($"{place} - {price:f2}");
        }
        else
        {
            double price = Math.Round(budget * 0.9, 2);
            Console.WriteLine("Somewhere in Europe");
            Console.WriteLine($"Hotel - {price:f2}");
        }
    }
}
