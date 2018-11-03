using System;

class Program
{
    static void Main()
    {
        int one = int.Parse(Console.ReadLine());
        int two = int.Parse(Console.ReadLine());
        int three = int.Parse(Console.ReadLine());

        string time = DateTime.Parse("0:0:0").AddSeconds(one + two + three).ToString("m:ss");

        Console.WriteLine(time);
    }
}
