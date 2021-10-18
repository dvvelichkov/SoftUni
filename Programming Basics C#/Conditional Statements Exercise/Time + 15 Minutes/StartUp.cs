using System;

namespace Time___15_Minutes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesAdded = minutes + 15;
            if (hours < 23)
            {
                if (minutesAdded > 59)
                {
                    hours = hours + 1;
                    minutesAdded = minutesAdded - 60;
                    if (minutesAdded < 10)
                    {
                        Console.WriteLine(hours + ":" + "0" + minutesAdded);
                    }
                    else if (10 <= minutesAdded)
                    {
                        Console.WriteLine(hours + ":" + minutesAdded);
                    }
                }
                else if (minutesAdded <= 59)
                {
                    hours = hours + 0;
                    minutesAdded = minutesAdded + 0;
                    if (minutesAdded < 10)
                    {
                        Console.WriteLine(hours + ":" + "0" + minutesAdded);
                    }
                    else if (10 <= minutesAdded)
                    {
                        Console.WriteLine(hours + ":" + minutesAdded);
                    }
                }
            }
            if (hours == 23)
            {
                if (minutesAdded > 59)
                {
                    hours = hours - 23;
                    minutesAdded = minutesAdded - 60;
                    if (minutesAdded < 10)
                    {
                        Console.WriteLine(hours + ":" + "0" + minutesAdded);
                    }
                    else if (10 <= minutesAdded)
                    {
                        Console.WriteLine(hours + ":" + minutesAdded);
                    }
                }
                else if (minutesAdded <= 59)
                {
                    hours = hours + 0;
                    minutesAdded = minutesAdded + 0;
                    if (minutesAdded < 10)
                    {
                        Console.WriteLine(hours + ":" + "0" + minutesAdded);
                    }
                    else if (10 <= minutesAdded)
                    {
                        Console.WriteLine(hours + ":" + minutesAdded);
                    }
                }
            }
        }
    }
}
