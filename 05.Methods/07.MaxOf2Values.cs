using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        switch(type)
        {
            case "int":
                Console.WriteLine(GetMax(int.Parse(a), int.Parse(b)));
                break;
            case "string":
                Console.WriteLine(GetMax(a, b));
                break;
            case "char":
                Console.WriteLine(GetMax(char.Parse(a), char.Parse(b)));
                break;
        }
    }

    static int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }

    static char GetMax(char a, char b)
    {
        return a > b ? a : b;
    }

    static string GetMax(string a, string b)
    {
        if(a.CompareTo(b) > 0)
        {
            return a;
        }

        return b;
    }
}
