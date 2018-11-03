using System;

class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        double result = 0, a, b;

        switch (figure)
        {
            case "square":
                a = double.Parse(Console.ReadLine());
                result = a * a;
                break;
            case "rectangle":
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                result = a * b;
                break;
            case "circle":
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI * radius * radius;
                break;
            case "triangle":
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                result = a * b / 2;
                break;
        }

        Console.WriteLine(Math.Round(result, 3));
    }
}
