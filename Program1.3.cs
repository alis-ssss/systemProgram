using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уточним информацию о вас. Ответьте на следующие вопросы:");
            Console.WriteLine("Как ваше имя?");
            string name = Console.ReadLine();

            Console.WriteLine("\nСколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nКакой ваш знак зодиака?");
            string zodiacSign = Console.ReadLine();

            Console.WriteLine("\nЧем вы занимаетесь?");
            string working = Console.ReadLine();

            Console.WriteLine("\nКраткое описание:");
            Console.WriteLine($"Ваше имя {name}, вам {age} лет, вы по знаку зодиака {zodiacSign} и {working}.");
            Console.ReadKey();
        }
    }
}
