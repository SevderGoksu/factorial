using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Bir sayı giriniz ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç= {0} ", facturial(number));
            Console.ReadKey();
        }
        public static int facturial(int number)
        {
            if (number <= 1)
            { return number = 1; }
            else
            { return number * facturial(number - 1); }
           
        }
    }
}
