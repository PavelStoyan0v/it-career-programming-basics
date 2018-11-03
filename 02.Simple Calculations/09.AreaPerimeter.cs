using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        string area = (Math.PI * r * r).ToString("0.00");
        string perimeter = (2 * Math.PI * r).ToString("0.00");

        Console.WriteLine($"Area = {area}");
        Console.WriteLine($"Perimeter = {perimeter}");
    }
}
