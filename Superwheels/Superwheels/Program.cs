using System;
using System.Collections.Generic;

namespace Superwheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("total vehicles sold in april are :" + MonthSales(30));
            Console.WriteLine("total vehicles sold in may are :" + MonthSales(31));
            Console.WriteLine("total vehicles sold in june are :" + MonthSales(30));
            Console.WriteLine("total vehicles sold in july are :" + MonthSales(31));
            Console.WriteLine("total vehicles sold in aug are :" + MonthSales(31));
            Console.WriteLine("total vehicles sold in sep are :" + MonthSales(30));

            int aprsales = retailSales(30);
            int maysales = retailSales(31);
            int junsales = retailSales(30);
            int julsales = retailSales(30);
            int augsales = retailSales(31);
            int septsales = retailSales(30);

            Console.WriteLine("Total retail sales from apr to sept : " + (aprsales + maysales + junsales + julsales + augsales + septsales));
            Console.WriteLine("total corp sales from apr to sept : " + (corporateSales(31) + corporateSales(31) + corporateSales(31) + corporateSales(31) + corporateSales(31) + corporateSales(30)));

            string Startdateaug = "2024-08-15";
            string endDateAug = "2024-08-30";
            string Startdatesep = "2024-09-01";
            string endDatesep = "2024-09-15";  

            DateTime startDate1 = DateTime.Parse(Startdateaug);
            DateTime endDate1 = DateTime.Parse(endDateAug);
            DateTime startDate2 = DateTime.Parse(Startdatesep);
            DateTime endDate2 = DateTime.Parse(endDatesep);

            Console.WriteLine("total vehicles sold from aug 15 to sept 15 : " + (MonthSales((int)(endDate1 - startDate1).TotalDays) + MonthSales((int)(endDate2 - startDate2).TotalDays)));
        }

        static int MonthSales(int numberofdays)
        {
            int totalvehicles = 0;
            for (int i = 1; i <= numberofdays; i++)
            {
                totalvehicles = totalvehicles + (i * (i + 1) / 2);
            }
            return totalvehicles;
        }

        static int retailSales(int numberofdays)
        {
            int totalvehicles = 0;
            for (int i = 1; i <= numberofdays; i++)
            {
                if (i % 5 != 0)
                {
                    totalvehicles += i * (i + 1) / 2;
                }
            }
            return totalvehicles;
        }

        static int corporateSales(int numberofdays)
        {
            int totalvehicles = 0;
            for (int i = 0; i <= numberofdays; i++)
            {
                if (i % 5 == 0)
                {
                    totalvehicles = totalvehicles + (i * (i + 1)) / 2;
                }
            }
            return totalvehicles;
        }
    }
}
