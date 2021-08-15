using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermApp_MatthewGrinton
{
    public class OrderItem
    {
        public OrderItem(string n, string d, double p, string t, double q, double total, bool s)
        {
            this.name = n;
            this.description = d;
            this.price = p;
            this.productType = t;
            this.quantity = q;
            this.totalPrice = total;
            this.sale = s;
        }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string productType { get; set; }
        public double quantity { get; set; }
        public double totalPrice { get; set; }
        public bool sale { get; set; }

        public override string ToString()
        {
            return $"{name, -10} {price, -10} {quantity, -10} {sale, 10}";
        }
    }
}
