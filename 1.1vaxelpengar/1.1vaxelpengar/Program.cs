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
            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma      : ");
                    subTotal = double.Parse(Console.ReadLine());

                    if (subTotal > 0.49)
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
                        return;
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
                        return;
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
            Console.WriteLine("{0,-15}:{1,17:c}", "Totalt", subTotal);
            Console.WriteLine("{0,-15}:{1,17:c}", "Öresavrundning", roundingOffAmount);
            Console.WriteLine("{0,-15}:{1,17:c0}", "Att betala", totalToPay);
            Console.WriteLine("{0,-15}:{1,17:c0}", "Kontant", total);
            Console.WriteLine("{0,-15}:{1,17:c0}", "Tillbaka", amountBack);
            Console.WriteLine("---------------------------------");

            //% operator
            uint remaningAmount = amountBack / 500;
            if (remaningAmount > 0)
            {
                Console.WriteLine(" {0,10}   :{1,2}","500-lappar", remaningAmount);
            }

            amountBack %= 500;
            remaningAmount = amountBack / 100;
            if (remaningAmount > 0)
            {
                Console.WriteLine(" {0,10}   :{1,2}","100-lappar", remaningAmount);
            }

            amountBack %= 100;
            remaningAmount = amountBack / 50;
            if (remaningAmount > 0)
            {
                Console.WriteLine(" {0,10}   :{1,2}", "50-lappar", remaningAmount);
            }

            amountBack %= 50;
            remaningAmount = amountBack / 20;
            if (remaningAmount > 0)
            {
                Console.WriteLine(" {0,10}   :{1,2}", "20-lappar", remaningAmount);
            }

            amountBack %= 20;
            remaningAmount = amountBack / 10;
            if (remaningAmount > 0)
            {
                Console.WriteLine(" {0,10}   :{1,2}", "10-kronor", remaningAmount);
            }

            amountBack %= 10;
            remaningAmount = amountBack / 5;
            if (remaningAmount > 0)
            {
                Console.WriteLine(" {0,10}   :{1,2}", "5-kronor", remaningAmount);
            }

            amountBack %= 5;
            remaningAmount = amountBack / 1;
            if (remaningAmount > 0)
            {
                Console.WriteLine(" {0,10}   :{1,2}", "1-kronor", remaningAmount);
            }
            Console.WriteLine();
        }
    }
}
