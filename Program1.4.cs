using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalImages = 52;
            int imagesInRow = 3;
            int fullRows = totalImages / imagesInRow;
            int remainingImages = totalImages % imagesInRow;

            Console.WriteLine($"Можно сформировать {fullRows} полных рядов.");
            Console.WriteLine($"{remainingImages} изображений останется.");
            Console.ReadKey();
        }
    }
}
