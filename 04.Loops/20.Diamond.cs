using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if(n == 1 || n == 2)
        {
            Console.WriteLine(new string('*', n));
        }
        int even = n % 2 == 0 ? 1 : 0;
        int stars = n % 2 == 0 ? 2 : 1;

        Console.WriteLine(new string('-', (n - stars) / 2) + new string('*', stars) + new string('-', (n - stars) / 2));
        int middleDashes = n % 2 == 0 ? 2 : 1;
        for (int i = 0; i < n / 2 - 1 - even; i++)
        {
            Console.WriteLine($"{new string('-', (n - middleDashes - 2) / 2)}*{new string('-', middleDashes)}*{new string('-', (n - middleDashes - 2) / 2)}");
            middleDashes += 2;
        }

        for(int i = n / 2 - even; i > 0; i--)
        {
            Console.WriteLine($"{new string('-', (n - middleDashes - 2) / 2)}*{new string('-', middleDashes)}*{new string('-', (n - middleDashes - 2) / 2)}");
            middleDashes -= 2;
        }
        Console.WriteLine(new string('-', (n - stars) / 2) + new string('*', stars) + new string('-', (n - stars) / 2));
    }
}
