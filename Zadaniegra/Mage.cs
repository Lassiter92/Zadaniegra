using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniegra
{
    public class Mage : Hero

    {
        public Mage()
        {
            Name = "Xardas";
            Hp = 100;
            Strength = 3;
            Ap = 16;
            Console.WriteLine($"Imie: {Name}, Punkty życia: {Hp}, Siła: {Strength}, Moc magiczna {Ap}");
        }
    }
}
