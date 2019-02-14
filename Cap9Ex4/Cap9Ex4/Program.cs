using System;
using Cap9Ex4.Entities;
using Cap9Ex4.Entities.Enums;
using System.Globalization;


namespace Cap9Ex4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), true, out status);

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int qtItens = int.Parse(Console.ReadLine());
            for(int i = 0; i<qtItens; i++) {
                Console.WriteLine($"Enter #{(i+1)} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int qt = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qt, productPrice, product);

                order.AddItem(orderItem);



            }


            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Cliente: " + order.Client.Name+" (" + order.Client.BirthDate.ToString("dd/MM/yyyy") + ") - " + order.Client.Email);
            Console.WriteLine("Order items: ");
            Console.WriteLine(order.ItensDoPedido());
            Console.WriteLine("Total price: $" + order.Total().ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
            



        }
    }
}
