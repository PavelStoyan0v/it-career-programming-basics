using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] couples = new int[n];
        int difference = 0;

        for(int i = 0; i < n; i++)
        {
            couples[i] = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n - 1; i++)
        {
            if(Math.Abs(couples[i] - couples[i + 1]) > difference)
            {
                difference = Math.Abs(couples[i] - couples[i + 1]);
            }
        }

        if(difference == 0)
        {
            Console.WriteLine($"Yes, value={couples[0]}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={difference}");
        }
    }
}
