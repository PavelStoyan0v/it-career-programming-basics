using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            max = number > max ? number : max;
        }

        Console.WriteLine(max);
    }
}
