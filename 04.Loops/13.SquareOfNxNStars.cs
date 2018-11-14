using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(new StringBuilder().Insert(0, "* ", 5));
        }
    }
}
