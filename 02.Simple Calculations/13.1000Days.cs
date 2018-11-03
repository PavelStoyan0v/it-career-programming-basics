using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
        Console.WriteLine(date.AddDays(999).ToString("dd-MM-yyy"));
    }
}
