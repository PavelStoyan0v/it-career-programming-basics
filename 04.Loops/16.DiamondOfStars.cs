using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + StringRepeat("* ", i));
        }
        for(int i = n - 1; i > 0; i--)
        {
            Console.WriteLine(new string(' ', n - i) + StringRepeat("* ", i));
        }
    }

    static string StringRepeat(string repeatable, int times)
    {
        return new StringBuilder()
            .Insert(0, repeatable, times)
            .ToString()
            .Trim();
    }
}
