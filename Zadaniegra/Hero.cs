namespace Zadaniegra
{
    public class Hero
    {
        private string name;
        private int hp;
        private int strength;
        private int ap;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Hp
        {
            get { return hp; }
            set
            {
                hp = value;
                if (hp > 100)
                {
                    hp = 100;
                }
                if (hp < 0)
                {
                    hp = 0;
                }
            }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Ap
        {
            get { return ap; }
            set { ap = value; }
        }

        // metody leczenie i obrazenia nie działają!! 20.09.2022
        public int Leczenie(int wartoscLeczenia)
        {
            return Hp + wartoscLeczenia;
        }

        public int Obrazenia(int wartoscObrazen)
        {
            return Hp - wartoscObrazen;
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


    }
}
