using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        double[] percentage = new double[3]
        {
            numbers.Where(x => x % 2 == 0).Count(),
            numbers.Where(x => x % 3 == 0).Count(),
            numbers.Where(x => x % 4 == 0).Count()
        };

        foreach (double item in percentage)
        {
            double percent = item / n * 100;
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
