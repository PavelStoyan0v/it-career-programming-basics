using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            min = number < min ? number : min;
        }

        Console.WriteLine(min);
    }
}
