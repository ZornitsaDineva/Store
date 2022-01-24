using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Appliance : Product
    {
        //model, production date and weight
        private string model;
        private DateOnly productionDate;
        private decimal weight;

        public string Model { get { return model; } set { model = value; } }
        public DateOnly ProductionDate { get { return productionDate; } set { productionDate = value; } }
        public decimal Weight { get { return weight; } set { weight = value; } }

        public override int GetDiscountPercent(DateTime purshaseTime)
        {

            //5% discount on all appliances that cost above $999 and are purchased during the weekend
            if (Price > 999 && (purshaseTime.DayOfWeek == DayOfWeek.Saturday || purshaseTime.DayOfWeek == DayOfWeek.Sunday))
            {
                return 5;

            }
            return 0;

        }
    }
}