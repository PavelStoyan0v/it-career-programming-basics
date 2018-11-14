using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{new string('*', n * 4 / 2)}{new string(' ', n)}{new string('*', n * 4 / 2)}");
        for(int i = 0; i < n - 2; i++)
        {
            // n is even -> b = 1
            // n is odd -> b = 0;
            int b = n % 2 == 0 ? 1 : 0;

            //determine if i == middle and set the char to '|'
            char middle = i == (n - 2) / 2 - b ? '|' : ' ';
            Console.WriteLine($"*{new string('/', n * 4 / 2 - 2)}*{new string(middle, n)}*{new string('/', n * 4 / 2 - 2)}*");
        }
        Console.WriteLine($"{new string('*', n * 4 / 2)}{new string(' ', n)}{new string('*', n * 4 / 2)}");
    }
}
