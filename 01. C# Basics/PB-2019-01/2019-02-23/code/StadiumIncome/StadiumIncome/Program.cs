using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumSectors = int.Parse(Console.ReadLine());     // broi sektori
            int capacityOfStadium = int.Parse(Console.ReadLine());   // kapacitet na stadiona
            double sumForOneTicket = double.Parse(Console.ReadLine());  // cena na 1 bilet
            double allProfit = capacityOfStadium * sumForOneTicket;  // obshta pechalba
            double incomeForOneSector = allProfit / sumSectors;  // prihod ot 1 sektor
            double moneyForCharity = (allProfit - (incomeForOneSector * 0.75)) / 8; // pari za blagotvoritelnost
            Console.WriteLine($"Total income - {allProfit:F2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:F2} BGN");

        }
    }
}
