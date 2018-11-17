using System;

class Program
{
    static void Main()
    {
        int V = int.Parse(Console.ReadLine());
        int P1 = int.Parse(Console.ReadLine());
        int P2 = int.Parse(Console.ReadLine());
        double H = double.Parse(Console.ReadLine());

        double result = P1 * H + P2 * H;

        if(result > V)
        {
            Console.WriteLine($"For {H} hours the pool overflows with {result - V} liters.");
        }
        else
        {
            int percent1 = (int)(P1 / (double)(P1 + P2) * 100);
            int percent2 = (int)(P2 / (double)(P1 + P2) * 100);
            int pool = (int)(result / V * 100);
            Console.WriteLine($"The pool is {pool}% full. Pipe 1: {percent1}%. Pipe 2: {percent2}%.");
        }
    }
}
