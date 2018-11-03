using System;

class Program
{
    static void Main()
    {
        int points = int.Parse(Console.ReadLine());

        double bonus = 0;

        if(points <= 100)
        {
            bonus = 5;
        }
        else if(points <= 1000)
        {
            bonus = 0.2 * points;
        }
        else if(points > 1000)
        {
            bonus = 0.1 * points;
        }

        bonus += points % 2 == 0 ? 1 : 0; //if even +1 bonus
        bonus += points % 10 == 5 ? 2 : 0; //if ends in 5 +2 bonus

        Console.WriteLine(bonus);
        Console.WriteLine(points + bonus);
    }
}
