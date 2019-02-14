using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap10Ex2.Entities;

namespace Cap10Ex2 {
    class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++) {
                Console.WriteLine($"Product #{(i+1)} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char pr = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(pr == 'c' || pr == 'C') {
                    products.Add(new Product(name, price));

                }else if(pr == 'u' || pr == 'U') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                } else {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product pr in products) {
                Console.WriteLine(pr.PriceTag());
            }

            Console.ReadLine();

        }
    }
}
