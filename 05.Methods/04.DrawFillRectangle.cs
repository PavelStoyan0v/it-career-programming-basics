using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSquare(n);
    }

    static void PrintSquare(int n)
    {
        Console.WriteLine(new string('-', n * 2));

        for(int i =  0; i < n - 2; i++)
        {
            Console.WriteLine($"-{StringRepeat("\\/", (n * 2 -  2) / 2)}-");
        }

        Console.WriteLine(new string('-', n * 2));
    }

    static string StringRepeat(string repeatable, int times)
    {
        return new StringBuilder()
            .Insert(0, repeatable, times)
            .ToString()
            .Trim();
    }
}
