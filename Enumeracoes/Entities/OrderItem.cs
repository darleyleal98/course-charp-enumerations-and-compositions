using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Enumeracoes.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }    

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Product.Name}, {Price:c}, {Quantity}, ");
            builder.Append($"Subtotal: R$ {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");

            return builder.ToString();
        }
    }
}
