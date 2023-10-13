using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            builder.AppendLine($"{Product.Name}, {Price:c},");
            builder.AppendLine($"{Quantity},");
            builder.AppendLine($"Subtotal: {SubTotal():c}");
            return builder.ToString();
        }
    }
}
