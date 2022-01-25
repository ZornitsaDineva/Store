using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Food : Perishable
    {
        public Food(string name, string brand, decimal price, DateTime expiration) : base(name, brand, price, expiration)
        {
        }
    }
}
