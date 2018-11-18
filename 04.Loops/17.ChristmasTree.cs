using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n + 1; i++)
        {
            Console.WriteLine($"{new string(' ', n + 1 - i)}{new string('*', i - 1)} | {new string('*', i - 1)}");
        }
    }
}
