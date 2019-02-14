using System;
using Cap9Ex4.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Cap9Ex4.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }
        public double Total() {
            double soma = 0.0;
            foreach(OrderItem item in Items) {
                soma += item.SubTotal();
            }
            return soma;
        }

        public string ItensDoPedido() {
            StringBuilder sb = new StringBuilder();
            
            foreach(OrderItem item in Items) {
                sb.Append(item.Produt.Name);
                sb.Append(", $");
                sb.Append(item.Produt.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                    

            }
            return sb.ToString();
        }

    }
}
