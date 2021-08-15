using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermApp_MatthewGrinton
{
    public class Product
    {
        public Product(string n, string d, string t)
        {
            this.name = n;
            this.description = d;
            this.productType = t;
        }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string productType { get; set; }

        public string viewPrice()
        {
            return "$" + this.price;
        }

        public override string ToString()
        {
            return ""+ this.name + "\t" + this.description + "\t " + viewPrice() + "\t" + this.productType;
        }
    }
}
