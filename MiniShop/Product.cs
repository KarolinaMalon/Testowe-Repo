using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private String name;
        private double price;
        private String descr = String.Empty; // ""
        private UInt16 version = 0;
        private Boolean promo = false;
        private Boolean active = true;

        public double ProductPrice { get { return Product.price} }

        // ustawianie parametrów
        public void SetParam(int id, String name, double price, String descr = "")
        {
            //
        }

        //zmiana ceny
        public void ChangePrice(double newPrice)
        {

        }
        //zmiana opisu
        public void ChangeDescription(string newDescr)
        {

        }

        //dostępność produktów
        public void setActive(bool isActive)
        {
            this.active = isActive;
        }
    }
}
