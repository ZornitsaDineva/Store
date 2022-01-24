using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class OrderLine
    {
        private Product product;
        private decimal quantity;

        public Product Product { get { return product; } set { product = value; } } 
        public decimal Quantity { get { return quantity; } set { quantity = value; } }  


    }
}
