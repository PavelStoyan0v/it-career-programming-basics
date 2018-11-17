using System;

class Program
{
    static void Main()
    {
        double vegetablesPrice = double.Parse(Console.ReadLine());
        double fruitsPrice = double.Parse(Console.ReadLine());
        int kgVegetables = int.Parse(Console.ReadLine());
        int kgFruits = int.Parse(Console.ReadLine());

        double price = (vegetablesPrice * kgVegetables + fruitsPrice * kgFruits) / 1.94;
        Console.WriteLine(price);
    }
}
