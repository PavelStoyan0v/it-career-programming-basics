using System;

class Program
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = Math.Round(side * h / 2, 2);
        Console.WriteLine($"Triangle area = {area}");
    }
}
