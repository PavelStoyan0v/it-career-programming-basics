using System;

class Program
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        int rows = (int)Math.Floor(w / 1.2);
        int cols = (int)Math.Floor((h - 1) / 0.7);

        Console.WriteLine(rows * cols - 3);
    }
}
