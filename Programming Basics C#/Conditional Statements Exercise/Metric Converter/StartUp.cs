using System;

namespace Metric_Converter
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double inputValueToBeConverted = double.Parse(Console.ReadLine());
            string inputUnitValue = Console.ReadLine();
            string outputUnitValue = Console.ReadLine();
            if (inputUnitValue == "mm" && outputUnitValue == "m")
            {
                Console.WriteLine($"{(inputValueToBeConverted * 0.001):f3}");
            }
            else if(inputUnitValue == "cm" && outputUnitValue == "m")
            {
                Console.WriteLine($"{(inputValueToBeConverted * 0.01):f3}");
            }
            else if (inputUnitValue == "m" && outputUnitValue == "m")
            {
                Console.WriteLine($"{(inputValueToBeConverted):f3}");
            }
            else if (inputUnitValue == "mm" && outputUnitValue == "cm")
            {
                Console.WriteLine($"{(inputValueToBeConverted * 0.1):f3}");
            }
            else if (inputUnitValue == "cm" && outputUnitValue == "mm")
            {
                Console.WriteLine($"{(inputValueToBeConverted * 10):f3}");
            }
            else if (inputUnitValue == "m" && outputUnitValue == "cm")
            {
                Console.WriteLine($"{(inputValueToBeConverted * 100):f3}");
            }
            else if (inputUnitValue == "mm" && outputUnitValue == "mm")
            {
                Console.WriteLine($"{(inputValueToBeConverted):f3}");
            }
            else if (inputUnitValue == "cm" && outputUnitValue == "cm")
            {
                Console.WriteLine($"{(inputValueToBeConverted):f3}");
            }
            else if (inputUnitValue == "m" && outputUnitValue == "mm")
            {
                Console.WriteLine($"{(inputValueToBeConverted * 1000):f3}");
            }
        }
    }
}
