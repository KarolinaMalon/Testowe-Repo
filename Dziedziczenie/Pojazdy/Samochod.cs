﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class Samochod : Pojazd
    {

        public void Uruchom()
        {
            Console.WriteLine("silnik start");
        }
        public void Zatankuj()
        {
            Console.WriteLine("Zatankuj PB/LPG/ON");
        }
        public void Zatrzymaj()
        {
            Console.WriteLine("silnik stop");
        }
    }
}
