using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsFabric
{
    public class AppleJuiceWithName : AppleJuice
        
    {
        public string _appleJuiceName;

        public AppleJuicewithName();
            {
                Random random = new Random();
                int volumeInMl = random.Next(900, 1000);
                double volumeInL = (double)volumeInMl / 1000;

                _volume = volumeInL;

            }

        }
    }
}
}
