using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.KlasaAbstrakcyjna
{
    class Product : AbstractProduct
    {
        public Product(String name, double price) : base(name, price)
    }
}
