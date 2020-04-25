using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień03
{
    class Samochod
    {
        private String marka;
        private int predkoscMax;

        // deklaracja właściwości klasy (property)
        public int Predkosc {
            get { return predkoscMax; }
            set { 
                if (value <= 0) 
                {
                    Console.WriteLine("Predkosc >=0");
                }
                else
                {
                    predkoscMax = value;
                }
                }
        }

        internal void LiczbaDrzwi()
        {
            throw new NotImplementedException();
        }

        public Samochod(string marka, int predkosc)
        {
            this.marka = marka;
            predkoscMax = predkosc;
        }

        /// <summary>
        /// Metoda zmienia prędkość maks.
        /// </summary>
        /// <param name="predkosc">nowa prędkość maks.</param>
        public void UstawPredkoscMax(int predkosc)
        {
            predkoscMax = predkosc;
        }

        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }
    }
}
