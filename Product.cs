using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product
    {
        private string name;
        private string brand;
        private decimal price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string name, string brand, decimal price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
        }

        public virtual int GetDiscountPercent(DateTime purshaseTime)
        {
            return 0;
        }

    }
}
