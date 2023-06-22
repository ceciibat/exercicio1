using System;
using System.Globalization;

namespace Fix.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() 
        {
        }

        // é sempre bom fazer um construtor padrão

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

        // o que aprendi: que devo parar de tratar método/função como se fosse contrutor
        // e não colocar parâmetros desnecessários!!

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

        // também posso fazer um override aqui e depois chamar o nome da classe pro sb.


    }
}
