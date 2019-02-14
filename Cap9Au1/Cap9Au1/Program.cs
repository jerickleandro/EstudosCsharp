using Cap9Au1.Entities;
using Cap9Au1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9Au1 {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
        Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os;
            Enum.TryParse("Delivered", true, out os);

            Console.WriteLine(os);
            Console.ReadLine();


        }
    }
}
