using System;

class Program
{
    static void Main()
    {
        DateTime exam = DateTime.Parse($"{Console.ReadLine()}:{Console.ReadLine()}");
        DateTime arrival = DateTime.Parse($"{Console.ReadLine()}:{Console.ReadLine()}");
        TimeSpan difference = exam.Subtract(arrival);

        string timeResult = "";
        if (Math.Abs(difference.TotalHours) < 1)
        {
            timeResult = $"{difference.Minutes} minutes";
        }
        else
        {
            string time = difference.ToString(@"h\:mm");
            timeResult = $"{time} hours";
        }

        int totalMinutes = (int)difference.TotalMinutes;

        if (totalMinutes < 0)
        {
            Console.WriteLine("Late");
            Console.WriteLine($"{timeResult} after the start");
        }
        else if(totalMinutes > 30)
        {
            Console.WriteLine("Early");
            Console.WriteLine($"{timeResult} before the start");
        }
        else
        {
            Console.WriteLine("On time");
            if (totalMinutes != 0)
            {
                Console.WriteLine($"{timeResult} before the start");
            }
        }
    }
}
