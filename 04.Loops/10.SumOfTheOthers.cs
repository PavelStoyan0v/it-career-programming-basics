using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum = 0;

        for(int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        for(int i = 0; i < n; i++)
        {
            if(numbers[i] == sum - numbers[i])
            {
                Console.WriteLine($"Yes\nSum = {numbers[i]}");
                return;
            }
        }

        int difference = Math.Abs(sum - numbers.Max() * 2);
        Console.WriteLine($"No\nDiff = {difference}");
    }
}
