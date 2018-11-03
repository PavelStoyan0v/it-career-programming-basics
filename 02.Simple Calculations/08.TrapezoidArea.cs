using System;

class Program
{
    static void Main()
    {
        double b1 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine($"Trapezoid area = {(b1 + b2) * h / 2}");

    }
}
