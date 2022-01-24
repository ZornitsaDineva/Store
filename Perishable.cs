using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Perishable : Product
    {
        private DateTime expiration;

        public DateTime Expiration
        {
            get { return expiration; }
            set { expiration = value; }
        }

        public override int GetDiscountPercent(DateTime purshaseTime)
        {
            //a discount is added - 10 % if the expiration date is within 5 days of the purchase date and 50 % if the product at the date of purchase.

            if (purshaseTime.Date < expiration.Date && expiration.Date <= purshaseTime.Date.AddDays(5))
            {
                return 10;

            }
            else if (expiration.Date == purshaseTime.Date)
            {
                return 50;
            }

            return 0;

        }

    }
}
