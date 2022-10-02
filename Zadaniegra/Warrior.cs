using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadaniegra
{
    public class Warrior : Hero
    {
        public Warrior()
        {

            Name = "Geralt";
            Hp = 100;
            Strength = rnd.Next(3, 19); // Siła w przedziale 3k6 (3-18)
            Console.WriteLine($"Imie: {Name}, Punkty życia: {Hp}, Siła: {Strength}");
        }

        public void ShowDmg()
        {
            int dmg;
            if (Hp < 5)     //jeśli życie wojownika spada poniżej 5 obrażenia są równe jego parametrowi siły bazowej
            {
                dmg = Strength;
                Console.WriteLine($"Siła ataku wojownika: {dmg}");
            }
            else
            {
                dmg = Strength * Hp;
                Console.WriteLine($"Siła ataku wojownika: {dmg}");
            }

        }
    }
}
