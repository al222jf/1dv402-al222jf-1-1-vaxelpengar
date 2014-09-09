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
            double total;
            int amount;
            double subTotal;

            // user input
            Console.Write("Ange totalsumma      : ");
            total = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp : ");
            amount = int.Parse(Console.ReadLine());

            //rounding


            //recipt
            Console.WriteLine();
            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Totalt       :   {0:c}", total);
            Console.WriteLine("Öresavrundning   :   ", )


        }
    }
}
