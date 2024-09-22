using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример 1: Имя и Фамилия\n");

            string name = "Демченко";
            string surname = "Алиса";

            Console.WriteLine("Значения переменных до обмена:");
            Console.WriteLine($"имя = {name} \nфамилия = {surname}");

            string temp = name;
            name = surname;
            surname = temp;

            Console.WriteLine("\nЗначения переменных после обмена:");
            Console.WriteLine($"имя = {name} \nфамилия = {surname}");
            Console.WriteLine();

            Console.WriteLine("\nПример 2: Кофе и Чай\n");

            string cupOfCoffee = "Чай";
            string cupOfTea = "Кофе";

            Console.WriteLine("Значения переменных до обмена:");
            Console.WriteLine($"чашка кофе = {cupOfCoffee} \nчашка чая = {cupOfTea}");

            string temp2 = cupOfCoffee;
            cupOfCoffee = cupOfTea;
            cupOfTea = temp2;

            Console.WriteLine("\nЗначения переменных после обмена:");
            Console.WriteLine($"чашка кофе = {cupOfCoffee} \nчашка чая = {cupOfTea}");
            Console.ReadKey();
        }
    }
}
