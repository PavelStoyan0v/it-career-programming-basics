using System;

class Program
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double deg = Math.Round(rad * 180 / Math.PI);
        Console.WriteLine(deg);
    }
}
