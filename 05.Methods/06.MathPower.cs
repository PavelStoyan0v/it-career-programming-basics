using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        Console.WriteLine(MathPower(number, power));
    }

    static double MathPower(double number, double power)
    {
        return Math.Pow(number, power);
    }
}
