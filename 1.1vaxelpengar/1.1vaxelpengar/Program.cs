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
            double subTotal=100;
            uint total = 1000;
            double roundingOffAmount;
            uint totalToPay;
            uint amountBack;
            
            // user input
            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma      : ");
                    subTotal = double.Parse(Console.ReadLine());

                    if (subTotal >= 0.49)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        Console.WriteLine();
                        Environment.Exit(0);
                        
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Erhållet belopp felaktigt.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

            //rounding
            totalToPay = (uint)Math.Round(subTotal);
            roundingOffAmount = totalToPay - subTotal;

            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp : ");
                    total = uint.Parse(Console.ReadLine());

                    if (totalToPay < total)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        Console.WriteLine();
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Erhållet belopp felaktigt.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

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
            Console.WriteLine("---------------------------------");


            //% operator
            uint remaningAmount = amountBack / 500;
            if (remaningAmount > 0)
            {
                Console.WriteLine("500-lappar {0}", remaningAmount);
            }

            amountBack %= 500;
            remaningAmount = amountBack / 100;
            if (remaningAmount > 0)
            {
                Console.WriteLine("100-lappar {0}", remaningAmount);
            }


        }
    }
}
