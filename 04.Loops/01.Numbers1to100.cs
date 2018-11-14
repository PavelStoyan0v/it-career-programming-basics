using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 100);
        Console.WriteLine(string.Join("\n", numbers));
    }
}
