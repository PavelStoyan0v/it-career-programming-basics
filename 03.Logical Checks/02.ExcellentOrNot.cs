using System;

class Program
{
    static void Main()
    {
        double result = double.Parse(Console.ReadLine());

        if(result >= 5.5)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}
