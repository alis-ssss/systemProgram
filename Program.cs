using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество пациентов: ");
            int numberOfPatients = Convert.ToInt32(Console.ReadLine());

            int receptionTime = 10;
            int totalWaitingTime = numberOfPatients * receptionTime;
            int waitingHours = totalWaitingTime / 60;
            int waitingMinutes = totalWaitingTime % 60;

            Console.WriteLine($"Вам предстоит ждать {waitingHours} часа и {waitingMinutes} минут.");
            Console.ReadKey();
        }
    }
}
