﻿using Enumeracoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Enumeracoes.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        List<OrderItem> Items { get; set; } = new List<OrderItem>();    
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            builder.AppendLine($"Order status: {Status}");
            builder.AppendLine($"Client: {Client}");
            builder.AppendLine("Order Items:");

            foreach (OrderItem item in Items)
            {
                builder.AppendLine(item.ToString());
            }
            builder.AppendLine($"Total price: R${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return builder.ToString();
        }
    }
}