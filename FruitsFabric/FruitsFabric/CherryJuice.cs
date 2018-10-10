using System;
namespace FruitsFabric
{
    public class CherryJuice
    {
        private double _volume;

        public CherryJuice()
        {
            Random random = new Random();
            int volumeInMl = random.Next(900, 1000);
            double volumeInL = volumeInMl / 1000;

            _volume = volumeInL;
        }

    }
}