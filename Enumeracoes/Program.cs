using System;

namespace Course
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter client data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("E-mail:");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data");
            // implementar status



            Console.Write("How many items to this order?");
            int quantityOrder = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            for (int i = 0; i < quantityOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name:");
                string productName = Console.ReadLine();

                Console.WriteLine("Product price:");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

            }
        }
    }
}