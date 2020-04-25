using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Przeciazanie
{
    class Wektor
    {
        public double x;
        public double y;

        public Wektor(double x, double y)
        {
            this.x = x, this.y = y;
        }
        public void Print()
        {
            Console.WriteLine("x={0}, y={1}", x, y);
        }
    }
}
