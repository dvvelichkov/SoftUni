using System;

namespace Projects_Creation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string architectsName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            var hoursNeeded = projectsCount * 3;
            Console.WriteLine($"The architect {architectsName} will need {hoursNeeded} hours to complete {projectsCount} project/s.");
        }
    }
}
