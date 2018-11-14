using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = SumOfEvenDigits(n) * SumOfOddDigits(n);
        Console.WriteLine(result);
    }

    static int SumOfOddDigits(int n)
    {
        n = Math.Abs(n);
        int sum = 0;
        while(n > 0)
        {
            sum += n % 10 % 2 != 0 ? n % 10 : 0;
            n /= 10;
        }
        return sum;
    }

    static int SumOfEvenDigits(int n)
    {
        n = Math.Abs(n);
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10 % 2 == 0 ? n % 10 : 0;
            n /= 10;
        }
        return sum;
    }
}
