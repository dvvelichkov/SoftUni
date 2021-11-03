using System;

namespace Fish_Tank
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int aquariumLength = int.Parse(Console.ReadLine());
            int aquariumWidth = int.Parse(Console.ReadLine());
            int aquariumHeight = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double percentageConverted = percentage * 0.01;
            double aquariumVolume = aquariumLength * aquariumWidth * aquariumHeight;
            double aquariumVolumeToBeFilledWithWater = (aquariumVolume - (aquariumVolume * percentageConverted))*0.001;
            Console.WriteLine(aquariumVolumeToBeFilledWithWater);
        }
    }
}


