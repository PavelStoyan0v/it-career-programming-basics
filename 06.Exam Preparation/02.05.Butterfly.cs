using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 2 * n - 1;
        for (int i = 0; i < n - 2; i++)
        {
            char fill = i % 2 == 0 ? '*' : '-';
            Console.WriteLine($@"{new string(fill, (width - 3) / 2)}\ /{new string(fill, (width - 3) / 2)}");
        }
        Console.WriteLine($"{new string(' ', width / 2)}@");
        for (int i = 0; i < n - 2; i++)
        {
            char fill = i % 2 == 0 ? '*' : '-';
            Console.WriteLine($@"{new string(fill, (width - 3) / 2)}/ \{new string(fill, (width - 3) / 2)}");
        }
    }
}
