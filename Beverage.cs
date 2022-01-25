using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Beverage : Perishable
    {
        public Beverage(string name, string brand, decimal price, DateTime expiration) : base(name, brand, price,expiration)
        {

        }
    }
}
