using System;

class Program
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();

        double bgn = money;

        switch(from)
        {
            case "USD":
                bgn = money * 1.79549;
                break;
            case "EUR":
                bgn = money * 1.95583;
                break;
            case "GBP":
                bgn = money * 2.53405;
                break;

        }

        switch(to)
        {
            case "BGN":
                money = bgn;
                break;
            case "USD":
                money = bgn / 1.79549;
                break;
            case "EUR":
                money = bgn / 1.95583;
                break;
            case "GBP":
                money = bgn / 2.53405;
                break;
        }

        Console.WriteLine($"{Math.Round(money, 2)} {to}");
    }
}
