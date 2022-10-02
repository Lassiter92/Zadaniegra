namespace Zadaniegra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Mage mage = new Mage();
            Hero hero = new Hero("Sekiro", 100, 70);

            hero.Obrazenia(40);
            warrior.Obrazenia(7);


        }

    }
}