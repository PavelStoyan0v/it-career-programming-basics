using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c);
        Console.WriteLine($"Latin alphabet: {string.Join(' ', alphabet)}");
    }
}
