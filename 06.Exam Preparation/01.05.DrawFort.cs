using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int middle = 2 * n - (4 + n / 2 * 2);
        Console.WriteLine($@"/{new string('^', n / 2)}\{new string('_', middle)}/{new string('^', n / 2)}\");

        for(int i = 0; i < n - 3; i++)
        {
            Console.WriteLine($"|{new string(' ', n * 2 - 2)}|");
        }

        Console.WriteLine($@"|{new string(' ', (2 * n - middle) / 2 - 1)}{new string('_', middle)}{new string(' ', (2 *n - middle) / 2 - 1)}|");
        Console.WriteLine($@"\{new string('_', n / 2)}/{new string(' ', middle)}\{new string('_', n / 2)}/");
    }
}
