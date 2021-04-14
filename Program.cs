using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1ConsumBankWebService.lt.lb;

namespace TP1ConsumBankWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            lt.lb.webservices.BLiquidity lb = new lt.lb.webservices.BLiquidity();

            Console.WriteLine(lb.getBLiquidityByRateType("201", "2002-09-12", "2002-09-12").InnerXml);
            Console.WriteLine(lb.getBLiquidityRatesByDate("2002-09-12").InnerXml);
            Console.WriteLine(lb.getBLiquidityRate("201", "2002-09-12"));
            Console.WriteLine(lb.getBLiquidityRateTypes().InnerXml);
            Console.WriteLine(lb.getBLiquidityRatesByDate_XmlString("2002-09-12"));
            Console.WriteLine(lb.getLatestBLiquidityRate("2002-09-12"));
            Console.ReadLine();
        }
    }
}
