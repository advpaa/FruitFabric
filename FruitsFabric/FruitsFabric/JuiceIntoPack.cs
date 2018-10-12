using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsFabric
{
    static class JuiceIntoPack
    {
        public static double JuiceIntoPacks()

        {
            Random random = new Random();
            int volumeInMl = random.Next(900, 1000);
            double volumeInL = (double)volumeInMl / 1000;
            return volumeInL;
        }

    }
}
