using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        Console.WriteLine(password == "s3cr3t!P@ssw0rd" ? "Welcome" : "Wrong password!");
    }
}
