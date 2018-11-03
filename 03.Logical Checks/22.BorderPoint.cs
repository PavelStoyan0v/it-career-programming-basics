using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool inside = x > x1 && x < x2 && y > y1 && y < y2;
        bool outside = x < x1 || x > x2 || y < y1 || y > y2;

        if(inside || outside)
        {
            Console.WriteLine("Inside / Outside");
        }
        else
        {
            Console.WriteLine("Border");
        }
    }
}
