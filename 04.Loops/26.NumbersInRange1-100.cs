using System;

class Program
{
    static void Main()
    {
        int number = -1;
        while (number < 1 || number > 100)
        {
            number = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(number);
    }
}
