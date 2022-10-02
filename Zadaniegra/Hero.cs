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
                if (hp > 100)
                {
                    hp = 100;
                }
                if (hp < 0)
                {
                    hp = 0;
                }
                hp = value;
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


        public int Leczenie(int wartoscLeczenia)
        {
            Hp = Hp + wartoscLeczenia;
            return Hp;
        }

        public int Obrazenia(int wartoscObrazen)
        {
            Hp = Hp - wartoscObrazen;
            return Hp;
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
            Console.WriteLine($"Imie: {name}, Punkty życia: {hp}, Siła: {strength}, Moc magiczna: {ap}");
        }


    }
}
