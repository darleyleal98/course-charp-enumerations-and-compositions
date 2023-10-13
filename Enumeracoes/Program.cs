using System;
using System.Globalization;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Course
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int quantityOrder = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            for (int i = 0; i < quantityOrder; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);
        }
    }
}