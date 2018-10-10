using System;
namespace FruitsFabric
{
    public class OrangeJuice
    {
        private double _volume;

        public OrangeJuice()
        {
            Random random = new Random();
            int volumeInMl = random.Next(900, 1000);
            double volumeInL = volumeInMl / 1000;

            _volume = volumeInL;
        }

    }
}
