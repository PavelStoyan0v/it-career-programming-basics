using System;

class Program
{
    static void Main()
    {
        int number = 1;

        while(number % 2 != 0)
        {
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch
            {

            }
        }

        Console.WriteLine(number);
    }
}
