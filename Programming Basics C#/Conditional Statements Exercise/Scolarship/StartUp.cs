using System;

namespace Scholarship
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());
            double socialScholarshipAmount = Math.Floor(0.35 * minimalWage);
            double excellentGradeScholarshipAmount = Math.Floor(averageGrade * 25);
            if (income < minimalWage && averageGrade > 4.50 && averageGrade < 5.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarshipAmount} BGN");
            }
            else if (income > minimalWage && averageGrade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentGradeScholarshipAmount} BGN");
            }
            else if (income < minimalWage && averageGrade >=5.50)
            {
                if (socialScholarshipAmount > excellentGradeScholarshipAmount)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarshipAmount} BGN");
                }
                else if (socialScholarshipAmount < excellentGradeScholarshipAmount)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentGradeScholarshipAmount} BGN");
                }
                else if (socialScholarshipAmount == excellentGradeScholarshipAmount)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentGradeScholarshipAmount} BGN");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
