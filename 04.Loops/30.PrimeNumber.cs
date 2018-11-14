using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = IsPrime(n) ? "Prime" : "Not Prime";
        Console.WriteLine(result);
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}
