using System;

class Program
{
    static void Main()
    {
        int magicNumber = int.Parse(Console.ReadLine());

        for (int one = 1; one <= 9; one++)
        {
            for (int two = 1; two <= 9; two++)
            {
                for (int three = 1; three <= 9; three++)
                {
                    for (int four = 1; four <= 9; four++)
                    {
                        for (int five = 1; five <= 9; five++)
                        {
                            for (int six = 1; six <= 9; six++)
                            {
                                int result = one * two * three * four * five * six;
                                if (result == magicNumber)
                                {
                                    int number = one * 100000 + two * 10000 + three * 1000 + four * 100 + five * 10 + six;
                                    Console.Write($"{number} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
