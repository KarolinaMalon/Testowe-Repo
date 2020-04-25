using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień03
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("FIAT", 180);
            //samochod.ustawPredkosc(200);
            samochod.LiczbaDrzwi();
            Console.WriteLine(samochod.Predkosc);
            Console.ReadKey();
        }
    }
}
