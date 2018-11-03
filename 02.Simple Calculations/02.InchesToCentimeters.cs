using System;

class Program
{
    static void Main()
    {
        Console.Write("inches = ");
        double inches = double.Parse(Console.ReadLine());
        double cm = inches * 2.54;
        Console.WriteLine($"Centimeters = {cm}");
    }
}
