using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обменяйте свое золото на кристаллы.");
            Console.WriteLine("Какое количество золота имеется?");
            int gold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько кристаллов вы хотите приобрести?");
            int crystals = Convert.ToInt32(Console.ReadLine());

            int crystalPrice = 15;
            int remainingGold = gold - (crystals * crystalPrice);

            Console.WriteLine($"\nКоличество кристаллов: {crystals}.");
            Console.WriteLine($"Остаток золота: {remainingGold}.");
            Console.ReadKey();
        }
    }
}
