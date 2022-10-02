namespace Zadaniegra
{
    public class Mage : Hero

    {
        public Mage()
        {
            Name = "Xardas";
            Hp = 100;
            Strength = rnd.Next(1,7); // Siła w przedziale 1k6 (1-6)
            Ap = rnd.Next(2, 13); // Moc magiczna w przedziale 2k6 (2-12)
            Console.WriteLine($"Imie: {Name}, Punkty życia: {Hp}, Siła: {Strength}, Moc magiczna {Ap}");


        }
    }
}
