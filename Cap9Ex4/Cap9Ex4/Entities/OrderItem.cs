using System;


namespace Cap9Ex4.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Produt { get; set; }


        public OrderItem() { }

        public OrderItem(int quantity, double price, Product produt) {
            Quantity = quantity;
            Price = price;
            Produt = produt;
        }

        public double SubTotal() {
            return Quantity * Price;
        }




    }
}
