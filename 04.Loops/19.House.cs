using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //if even 1 else 0
        int even = n % 2 == 0 ? 1 : 0;
        int stars = n % 2 == 0 ? 2 : 1;

        for(int i = 0; i < n / 2 - even; i++)
        {
            Console.WriteLine($"{new string('-', (n - stars) / 2)}{new string('*', stars)}{new string('-', (n - stars) / 2)}");
            stars += 2;
        }
        Console.WriteLine(new string('*', n));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine($"|{new string('*', n - 2)}|");
        }
    }
}
