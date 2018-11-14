using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"+ {StringRepeat("- ", n - 2)} +");
        for(int i = 0; i < n - 2; i++)
        {
            Console.WriteLine($"| {StringRepeat("- ", n - 2)} |");
        }
        Console.WriteLine($"+ {StringRepeat("- ", n - 2)} +");
    }

    static string StringRepeat(string repeatable, int times)
    {
        return new StringBuilder()
            .Insert(0, repeatable, times)
            .ToString()
            .Trim();
    }
}
