using System;

namespace Salary
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const double facebookFine = 150;
            const double instagramFine = 100;
            const double redditFine = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string websitesNames = "";

            for (int i = 0; i < openedTabs; i++)
            {
                websitesNames = Console.ReadLine();
                if (websitesNames == "Facebook")
                {
                    salary -= facebookFine;
                }
                if (websitesNames == "Instagram")
                {
                    salary -= instagramFine;
                }
                if (websitesNames == "Reddit")
                {
                    salary -= redditFine;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
