// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {

            Cart cart = new Cart();
            List<OrderLine> lines = new List<OrderLine>();

            OrderLine line1 = new OrderLine();
            Food product1 = new Food();
            product1.Name = "apple";
            product1.Price = 1.50M;
            product1.Brand = "BrandA";
            product1.Expiration = DateTime.Parse("2021-06-14");
            line1.Quantity = 2.45M;
            line1.Product = product1;
            lines.Add(line1);

            OrderLine line2 = new OrderLine();
            Beverage product2 = new Beverage();
            product2.Name = "milk";
            product2.Price = 0.99M;
            product2.Brand = "BrandM";
            product2.Expiration = DateTime.Parse("2022-02-02");
            line2.Quantity = 3;
            line2.Product = product2;
            lines.Add(line2);

            OrderLine line3 = new OrderLine();
            Clothes product3 = new Clothes();
            product3.Name = "T-shirt";
            product3.Price = 15.99M;
            product3.Brand = "BrandT";
            product3.Size = Clothes.SIZE.M;
            product3.Color = "violet";
            line3.Quantity = 2;
            line3.Product = product3;
            lines.Add(line3);

            OrderLine line4 = new OrderLine();
            Appliance product4 = new Appliance();
            product4.Name = "Laptop";
            product4.Price = 2345;
            product4.Brand = "BrandL";
            product4.Model = "ModelL";
            line4.Quantity = 1;
            line4.Product = product4;
            lines.Add(line4);

            //lines.Add(new Lines() { name = "apple", brand = "BrandA",quantity=2.45,price=1.50 });
            // lines.Add(new Lines() { name = "milk",brand="BrandM", quantity = 3, price = 0.99 });
            //lines.Add(new Lines() { name = "T-shirt", brand = "BrandT", size = "M", color = "violet", quantity = 2, price = 15.99 });
            // lines.Add(new Lines() { name = "Laptop", brand = "BrandL", model = "ModelL", quantity = 1, price = 2345 });

            cart.OrderLines = lines;

            Cashier cashier = new Cashier();
            DateTime purchaseTime = DateTime.Parse("2021-06-14 12:34:56");
            cashier.PrintReceipt(cart, purchaseTime);

        }
    }
}