using System;

class Program
{
    static void Main()
    {
        string hours = Console.ReadLine();
        string minutes = Console.ReadLine();

        DateTime date = DateTime.Parse($"{hours}:{minutes}").AddMinutes(15);

        Console.WriteLine(date.ToString("H:mm"));
    }
}
