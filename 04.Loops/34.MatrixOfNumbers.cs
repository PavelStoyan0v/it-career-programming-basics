using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                int num = row + col + 1;
                if(num > n)
                {
                    num = 2 * n - num;
                }
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
