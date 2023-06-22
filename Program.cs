using Fix.Entities;
using Fix.Entities.Enums;
using System.Globalization;

namespace Fix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);

            // o que aprendi: que pode-se e creio que fica melhor, instanciar o objeto logo após
            // conseguir os valores necessários nas variáveis temporárias
            // aqui por exemplo, instanciei logo o cliente depois de obter os dados

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            // aqui foi instanciado um pedido (order), após obter os dados necessários 

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i  = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double pprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(pname, pprice);

                // aqui foi instanciado um produto (product), após obter os dados necessários

                Console.Write("Quantity: ");
                int pquantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(pquantity, pprice, product);

                // aqui foi instanciado um item do pedido (orderItem), após obter os dados necessários

                order.AddItem(item);  
                
                // e aquii nós pegamos pedido pedido instanciado (order) e chamamos o método .AddItem()
                // e adicionamos como parâmetro o item do pedido (criado pouco antes), o item
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine(order);

            // por fim chamamos o order, pedido instanciado à cima e ele traz toda a formatação,
            // conforme pede o exercício.

        }
    }
}
