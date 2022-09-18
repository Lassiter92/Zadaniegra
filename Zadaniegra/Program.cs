using System.Threading.Channels;

namespace Zadaniegra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Mage mage = new Mage();
            Hero hero = new Hero("Sekiro", 30, 70);
        }
    }
}