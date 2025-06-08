using System;


namespace LojaVirtual{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Criando produtos
            var produto1 = new Produto(1, "Notebook", 3500.00m, "Eletrônicos");

            var produto2 = new Produto(2, "Mouse", 50.00m, "Periféricos");

            Console.WriteLine(produto1.Id);
            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
            Console.WriteLine(produto1.Categoria);

            Console.WriteLine(produto2.Id);
            Console.WriteLine(produto2.Nome);
            Console.WriteLine(produto2.Preco);
            Console.WriteLine(produto2.Categoria);

            Console.WriteLine("\n");

            // Criando cliente
            var cliente = new Cliente(1, "emanuel roque", "emanuel@email.com", "123.456.789-00");
            Console.WriteLine(cliente.Email);

            //criando pedido mais agora o item pedido agora serve na class pedido
            Console.WriteLine("\n");

            var pedido = new Pedido(1, cliente);

            pedido.AdicionarItem(produto1, 3); // aqui eu adiciono o item com a class itemPedido

            Console.WriteLine(pedido.ValorTotal);


            Console.WriteLine($"Pedido #{pedido.Id}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine($"Data: {pedido.Data}\n");

            //removendo o pedido
            //pedido.RemoverItem(1);

            Console.WriteLine(pedido.ValorTotal);

            Console.WriteLine("\n aplicando descontos:");

            // Aplicando descontos
            var descontoCategoria = new DescontoPorCategoriaStrategy("Eletrônicos", 10);
            var descontoQuantidade = new DescontoPorQuantidadeStrategy(2, 5);

            var descontoTotal = descontoCategoria.CalcularDesconto(pedido) +
                               descontoQuantidade.CalcularDesconto(pedido);

            // Exibindo informações do pedido
            Console.WriteLine($"Pedido #{pedido.Id}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine($"Data: {pedido.Data}");

            //valores finais
            Console.WriteLine($"\nSubtotal: R${pedido.ValorTotal:F2}");
            Console.WriteLine($"Desconto: R${descontoTotal:F2}");
            Console.WriteLine($"Total: R${(pedido.ValorTotal - descontoTotal):F2}");
            
        }
    }
}