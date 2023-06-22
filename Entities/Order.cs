using Fix.Entities.Enums;
using System.Text;
using System.Globalization;

namespace Fix.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set;} = new List<OrderItem>();

        // o que aprendi: que só devo criar atributos e métodos que me foram ordenados
        // [exceção do add e remove]

        public Order() 
        {
        }

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
            foreach  (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        // aqui temos a função Total() que soma todos os valores.
        // começa criando um double 0.0, depois faz-se um foreach para percorrer a lista Items
        // e aplicar o método SubTotal() em cada item do pedido,
        // no final ele retorna a soma total.

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));  // aqui fez-se a formatação da data
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {               
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));          
            return sb.ToString();
        }

        // aqui temos o digníssimo StringBuilder, que irá reunir todos os overrides das outras classes
        // nele também pode-se concatenar
        // no foreach, percorremos cada item da lista Items e o mostramos na tela com o .AppendLine
        // o item já vem pronto (formatado), pois foi feito um override na sua classe: OrderItem

    }
}
