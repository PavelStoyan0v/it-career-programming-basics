using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number < 100 && number != 0 || number > 200 && number != 0)
        {
            Console.WriteLine("invalid");
        }
    }
}