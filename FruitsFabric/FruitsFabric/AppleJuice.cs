using System;
namespace FruitsFabric
{
    public class AppleJuice
    {
        public double _volume;

        public AppleJuice()
        {
            Random random = new Random();
            int volumeInMl = random.Next(900, 1000);
            double volumeInL = (double)volumeInMl / 1000;

            _volume = volumeInL;

        }

    }
}