using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for(int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        double[] percentage = new double[5]
        {
            numbers.Where(x => x < 200).Count(),
            numbers.Where(x => x >= 200 && x < 400).Count(),
            numbers.Where(x => x >= 400 && x < 600).Count(),
            numbers.Where(x => x >= 600 && x < 800).Count(),
            numbers.Where(x => x >= 800).Count()
        };

        foreach(double item in percentage)
        {
            string percent = (item / n * 100).ToString("0.00");
            Console.WriteLine($"{percent}%");
        }
    }
}
