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
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine();
            builder.AppendLine();
            builder.AppendLine();

            return builder.ToString();
        }
    }
}
