using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniegra
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            Name = "Geralt";
            Hp = 100;
            Strength = 15;
            Console.WriteLine($"Imie: {Name}, Punkty życia: {Hp}, Siła: {Strength}");
        }
    }
}
