using System;

namespace Vacation_books_list
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int pagesInCurrentBook = int.Parse(Console.ReadLine());
            double pagesReadPerHour = double.Parse(Console.ReadLine());
            int daysForReadingTheBook = int.Parse(Console.ReadLine());
            double timeNeededForTheBook = pagesInCurrentBook / pagesReadPerHour;
            double hoursPerDay = timeNeededForTheBook / daysForReadingTheBook;
            Console.WriteLine(hoursPerDay);
        }
    }
}
