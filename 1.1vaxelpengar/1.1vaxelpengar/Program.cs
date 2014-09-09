using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare varibel
            double subTotal;
            uint total;
            double roundingOffAmount;
            uint totalToPay;
            uint amountBack;
            
            // user input
            Console.Write("Ange totalsumma      : ");
            subTotal = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp : ");
            total = uint.Parse(Console.ReadLine());

            //rounding
            totalToPay = (uint)Math.Round(subTotal);
            roundingOffAmount = totalToPay - subTotal;

            //amount back
            amountBack = total - totalToPay;

            //recipt
            Console.WriteLine();
            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Totalt           :   {0:c}", subTotal);
            Console.WriteLine("Öresavrundning   :   {0:c}", roundingOffAmount);
            Console.WriteLine("Att betala       :   {0:c0}", totalToPay);
            Console.WriteLine("Kontant          :   {0:c0}", total);
            Console.WriteLine("Tillbaka         :   {0:c0}", amountBack);


        }
    }
}
