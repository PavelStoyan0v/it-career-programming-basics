using System;

class Program
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string sex = Console.ReadLine();
        if(sex == "f")
        {
            if(age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
        else
        {
            if (age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else
            {
                Console.WriteLine("Master");
            }
        }
    }
}
