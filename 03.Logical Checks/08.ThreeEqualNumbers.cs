using System;

class Program
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        Console.WriteLine(num1 == num2 && num2 == num3 ? "yes" : "no");
    }
}
