using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int num = 1;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.Write($"{num} ");
                if (num == n) return;
                num++;
            }
            Console.WriteLine();
        }
    }
}
