using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cart 
    {
        private List<OrderLine> orderLines;

        public List<OrderLine> OrderLines { get { return orderLines; } set { orderLines = value; } }    

    }
}
