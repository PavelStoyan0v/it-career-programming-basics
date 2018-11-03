using System;

class Program
{
    static void Main()
    {
        double usd = double.Parse(Console.ReadLine());
        string bgn = (usd * 1.79549).ToString("0.00") + " BGN";
        Console.WriteLine(bgn);
    }
}
