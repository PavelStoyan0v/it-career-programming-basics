using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 1, b = 1;
        for(int i = 0; i < n; i++)
        {
            b = a + b;
            a = b - a;
        }

        Console.WriteLine(a);
    }
}
