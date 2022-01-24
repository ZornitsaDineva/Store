using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cashier
    {

        public void PrintReceipt(Cart cart, DateTime purchaseTime)
        {
            Console.WriteLine("Date: " + purchaseTime);
            Console.WriteLine("---Products---");
            Console.WriteLine();
            decimal subtotal = 0;
            decimal totalDiscount = 0;

            foreach (OrderLine orderLine in cart.OrderLines)
            {
                /*< name > < brand >
                  < quantity > x < price per product> = < total price without discount >
                  # discount <discount %> <discount sum> (if applicable) */
                Product product = orderLine.Product;
                decimal orderLinePrice = orderLine.Quantity * product.Price;
                orderLinePrice = Decimal.Round(orderLinePrice, 2);

                subtotal = orderLinePrice + subtotal;

                Console.Write(product.Name + " " + product.Brand);
                if (product is Clothes)
                {
                    Clothes clothes = (Clothes)product;
                    Console.Write(" " + clothes.Size + " " + clothes.Color);
                }

                if (product is Appliance)
                {
                    Appliance appliance = (Appliance)product;
                    Console.Write(" " + appliance.Model);
                }

                Console.WriteLine();

                Console.WriteLine(orderLine.Quantity + " x $" + product.Price + " = $" + orderLinePrice);


                int discountPercent = product.GetDiscountPercent(purchaseTime);

                if (discountPercent > 0)
                {
                    decimal discount = (discountPercent * product.Price * orderLine.Quantity) / 100;
                    discount = Decimal.Round(discount, 2);
                    Console.WriteLine("#discount " + discountPercent + "% -$" + discount);
                    totalDiscount = discount + totalDiscount;
                }

                Console.WriteLine();
            }

            subtotal = Decimal.Round(subtotal, 2);
            totalDiscount = Decimal.Round(totalDiscount, 2);


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("SUBTOTAL: $" + subtotal);
            Console.WriteLine("DISCOUNT: -$" + totalDiscount);
            Console.WriteLine();
            Console.WriteLine("TOTAL: $" + Decimal.Round((subtotal - totalDiscount), 2));
        }
    }
}
