using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;

        for(int i = 1; i <= n; i++)
        {
            if(i % 2 == 0)
            {
                sumEven += int.Parse(Console.ReadLine());
            }
            else
            {
                sumOdd += int.Parse(Console.ReadLine());
            }
        }

        if(sumOdd == sumEven)
        {
            Console.WriteLine($"Yes\nSum = {sumOdd}");
        }
        else
        {
            Console.WriteLine($"No\nDiff = {Math.Abs(sumOdd - sumEven)}");
        }
    }
}
