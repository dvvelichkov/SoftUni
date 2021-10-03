using System;

namespace Area_of_Figures
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            switch (figureType)
            {
                case "square": double squareSideA = double.Parse(Console.ReadLine());
                    double squareArea = squareSideA * squareSideA;
                    Console.WriteLine($"{ squareArea:f3}"); break;
                case "rectangle": double rectangleSideA = double.Parse(Console.ReadLine());
                    double rectangleSideB = double.Parse(Console.ReadLine());
                    double rectangleArea = rectangleSideA * rectangleSideB;
                    Console.WriteLine($"{rectangleArea:f3}"); break;
                case "circle": double circleRadius = double.Parse(Console.ReadLine());
                    double circleArea = Math.PI * circleRadius * circleRadius;
                    Console.WriteLine($"{circleArea:f3}"); break; 
                case "triangle": double triangleSideA = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    double triangleArea = (triangleSideA * triangleHeight)/2;
                    Console.WriteLine($"{triangleArea:f3}"); break;
            }
        }
    }
}
