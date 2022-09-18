using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Zadaniegra
{
    internal class Hero
    {
        private string name;
        private int hp;
        private int strength;
        private int ap;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        
        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public int getHp()
        {
            return hp;
        }

        public void setStrength(int strength)
        {
            this.strength = strength;
        }

        public int getStrength()
        {
            return strength;
        }

        public void setAp(int ap)
        {
            this.ap = ap;
        }

        public int getAp()
        {
            return ap;
        }

        public Hero()
        {
            setName("Geralt");
            setHp(100);
            setStrength(50);
            Console.WriteLine($"{getName()} {getHp()} {getStrength()}");
        }

        public Hero(string name, int hp, int strength)
        {
            this.name = name;
            this.hp = hp;
            this.strength = strength;
            Console.WriteLine($"{name} {hp} {strength}");
        }

        public Hero(string name, int hp, int strength, int ap)
        {
            this.name = name;
            this.hp = hp;
            this.strength = strength;
            this.ap = ap;
            Console.WriteLine($"{name} {hp} {strength}");
        }
        
    }
}
