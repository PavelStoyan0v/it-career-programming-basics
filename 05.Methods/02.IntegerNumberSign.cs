using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSign(n);
    }

    static void PrintSign(int n)
    {
        string sign = "";
        if(n < 0)
        {
            sign = "negative";
        }
        else if(n == 0)
        {
            sign = "zero";
        }
        else
        {
            sign = "positive";
        }

        Console.WriteLine($"The number {n} is {sign}.");
    }
}
