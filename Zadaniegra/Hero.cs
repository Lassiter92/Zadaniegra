using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Zadaniegra
{
    class Hero
    {
        private string name;
        private int hp;
        private int strength;
        private int ap;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        
        public void SetHp(int hp)
        {
            this.hp = hp;
            if(hp > 100)
            {
                hp = 100;
            }else if(hp < 0)
            {
                hp = 1;
            }

            
        }

        public int GetHp()
        {
            return hp;
        }

        public void SetStrength(int strength)
        {
            this.strength = strength;
        }

        public int GetStrength()
        {
            return strength;
        }

        public void SetAp(int ap)
        {
            this.ap = ap;
        }

        public int GetAp()
        {
            return ap;
        }


        public Hero() { }

        public Hero(string name, int hp, int strength)
        {
            this.name = name;
            this.hp = hp;
            this.strength = strength;
            Console.WriteLine($"Imie: {name}, Punkty życia: {hp}, Siła: {strength}");
        }


        public Hero(string name, int hp, int strength, int ap)
        {
            this.name = name;
            this.hp = hp;
            this.strength = strength;
            this.ap = ap;
            Console.WriteLine($"{name} {hp} {strength}");
        }

        public void leczenie(int leczenie)
        {
            int wyleczone = GetHp() + leczenie;
            SetHp(wyleczone);
        }

        public void obrazenia(int obrazenia)
        {
            int otrzymaneObrazenia = GetHp() - obrazenia;
            SetHp(otrzymaneObrazenia);
        }
    }
    class Warrior : Hero
    {
        public Warrior()
        {
            SetName("Geralt");
            SetHp(100);
            SetStrength(50);
            Console.WriteLine($"Imie: {GetName()}, Punkty życia: {GetHp()}, Siła: {GetStrength()}");
        }
    }

    class Mage : Hero
    {
        public Mage()
        {
            SetName("Xardas");
            SetHp(100);
            SetStrength(20);
            SetAp(40);
            Console.WriteLine($"Imie: {GetName()}, Punkty życia: {GetHp()}, Siła: {GetStrength()}, Moc magiczna {GetAp()}");
        }
    }

}
