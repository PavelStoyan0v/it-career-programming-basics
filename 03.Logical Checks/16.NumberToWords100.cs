using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string part1 = "";
        string part2 = "";

        if(number < 0 || number > 100)
        {
            Console.WriteLine("invalid number");
            return;
        }

        if(number < 20 || number == 100)
        {
            switch(number)
            {
                case 0:
                    Console.WriteLine("zero");
                    return;
                case 1:
                    Console.WriteLine("one");
                    return;
                case 2:
                    Console.WriteLine("two");
                    return;
                case 3:
                    Console.WriteLine("three");
                    return;
                case 4:
                    Console.WriteLine("four");
                    return;
                case 5:
                    Console.WriteLine("five");
                    return;
                case 6:
                    Console.WriteLine("six");
                    return;
                case 7:
                    Console.WriteLine("seven");
                    return;
                case 8:
                    Console.WriteLine("eight");
                    return;
                case 9:
                    Console.WriteLine("nine");
                    return;
                case 10:
                    Console.WriteLine("ten");
                    return;
                case 11:
                    Console.WriteLine("eleven");
                    return;
                case 12:
                    Console.WriteLine("twelve");
                    return;
                case 13:
                    Console.WriteLine("thirteen");
                    return;
                case 14:
                    Console.WriteLine("fourteen");
                    return;
                case 15:
                    Console.WriteLine("fifteen");
                    return;
                case 16:
                    Console.WriteLine("sixteen");
                    return;
                case 17:
                    Console.WriteLine("seventeen");
                    return;
                case 18:
                    Console.WriteLine("eighteen");
                    return;
                case 19:
                    Console.WriteLine("nineteen");
                    return;
                case 100:
                    Console.WriteLine("one hundred");
                    return;
            }
        }


        switch(number / 10)
        {
            case 2:
                part1 = "twenty";
                break;
            case 3:
                part1 = "thirty";
                break;
            case 4:
                part1 = "forty";
                break;
            case 5:
                part1 = "fifty";
                break;
            case 6:
                part1 = "sixty";
                break;
            case 7:
                part1 = "seventy";
                break;
            case 8:
                part1 = "eighty";
                break;
            case 9:
                part1 = "ninety";
                break;

        }

        switch (number % 10)
        {
            case 1:
                part2 = "one";
                break;
            case 2:
                part2 = "two";
                break;
            case 3:
                part2 = "three";
                break;
            case 4:
                part2 = "four";
                break;
            case 5:
                part2 = "five";
                break;
            case 6:
                part2 = "six";
                break;
            case 7:
                part2 = "seven";
                break;
            case 8:
                part2 = "eight";
                break;
            case 9:
                part2 = "nine";
                break;
        }

        Console.WriteLine($"{part1} {part2}".Trim());
    }
}
