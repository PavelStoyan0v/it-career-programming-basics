using System;

class Program
{
    static void Main()
    {
        int kilometers = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();

        double price = 0;
        if(kilometers < 20)
        {
            price = time == "day" ? 0.79 : 0.9;
            price *= kilometers;
            price += 0.7;
        }
        else if(kilometers < 100)
        {
            price = 0.09 * kilometers;
        }
        else
        {
            price = 0.06 * kilometers;
        }

        Console.WriteLine(price);
    }
}
