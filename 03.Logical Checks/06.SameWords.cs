using System;

class Program
{
    static void Main()
    {
        string word1 = Console.ReadLine().ToLower();
        string word2 = Console.ReadLine().ToLower();

        Console.WriteLine(word1 == word2 ? "yes" : "no");
    }
}
