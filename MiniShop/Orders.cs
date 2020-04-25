using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Orders
    {

        // typ wyliczeniowy
        enum OrderStatus
        {
            NewOrder = 10,
            Complete = 20,
            Confirmed = 30,
            Shipped = 40,
            Returned = 50,
            Cancelled = 60
        }

        private String orderNumber;
        private List<OrderItem> items = new List<OrderItem>(); //utworzona pusta liczba
        private byte discount = 0;
        private String customerName;
        private String shipAddress;
        private String orderDate;
        private OrderStatus status = OrderStatus.NewOrder;

        //wartosc zamowienia jako property
        public double TotalAmount
        {
            get { return CalcTotalAmount(); }
        }

        // metody

        public bool AddProduct(Product product, int qnty)
        {
            //akcja dodania produktu do listy produktów
            if (status==OrderStatus.NewOrder && qnty > 0 && product != null)
            {
                items.Add(new OrderItem(product, qnty));
                return true;
            }
            else
            {
                return false;
            }
        } 

        public bool Clear()
        {
            if (status == OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        private double CalcTotalAmount()
        {
            double amount = 0.0;
            foreach (var item in items)
            {
                amount += item.ProductPrice * item.Qnty;
            }
            if (discount>0 && discount <= 100)
            {
                amount *= (100 - discount) / 100;
            }
            return amount;
        }

        public void Print()
        {
            Console.WriteLine("Elementy zamówienia:");
            foreach (var item in items)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}"
                    "", item.Qnty, item.ProductPrice, item.ProductPrice*item.Qnty);
            }
            Console.WriteLine("Do zapłaty: {0}", CalcTotalAmount() );
        }

    }
}
