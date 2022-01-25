using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Clothes : Product
    {
        //size (standard from XS, S, M, L, XL) and color
        public enum SIZE
        {
            XS,
            S,
            M,
            L,
            XL
        }

        private SIZE size;
        private string color;

        public Clothes(string name, string brand, decimal price, SIZE size, string color) : base(name, brand, price)
        {
            this.color = color;
            this.size = size;
        }

        public SIZE Size { get { return size; } set { size = value; } }
        public string Color { get { return color; } set { color = value; } }

        public override int GetDiscountPercent(DateTime purshaseTime)
        {

            //There is a 10% discount on all clothes bought during the working days
            if (purshaseTime.DayOfWeek != DayOfWeek.Saturday && purshaseTime.DayOfWeek != DayOfWeek.Sunday)
            {
                return 10;

            }
            return 0;

        }


    }
}
