using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(number % 2 == 0 ? "even" : "odd");
    }
}
