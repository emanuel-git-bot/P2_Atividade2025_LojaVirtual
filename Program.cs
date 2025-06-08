using System;

namespace LojaVirtual{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("========COMEÇO DO CODIGO===========");

            // Criando produtos
            var RealizarPedidos = new ProdutoFactory();
            var produto1 = RealizarPedidos.CriarProduto("Notebook", 3500.00m, "Eletrônicos");
            var produto2 = RealizarPedidos.CriarProduto("Mouse", 50.00m, "Periféricos");

            // Criando cliente

            var clientesFactory = new ClienteFactory();
            var cliente1 = clientesFactory.CriarCliente("benedito roque", "benedito@email.com", "123.456.789-00");
            var cliente2 = clientesFactory.CriarCliente("emanuel roque", "emanuel@email.com", "123.456.789-00");

            Console.WriteLine("\n");

            //criando pedido
            var pedidoFactory = new PedidoFactory();

            var pedido = pedidoFactory.CriarPedido(cliente1);
            var pedido2 = pedidoFactory.CriarPedido(cliente2);

            pedido.AdicionarItem(produto1, 3);
            pedido2.AdicionarItem(produto2, 5); // aqui eu adiciono o item com a class itemPedido e pedido

            // Aplicando descontos
            var descontoCategoria = new DescontoPorCategoriaStrategy("Eletrônicos", 10);
            var descontoQuantidade = new DescontoPorQuantidadeStrategy(2, 5);

            var descontoTotal = descontoCategoria.CalcularDesconto(pedido) +
                               descontoQuantidade.CalcularDesconto(pedido);

            var descontoTotal2 = descontoCategoria.CalcularDesconto(pedido) +
                               descontoQuantidade.CalcularDesconto(pedido);

            // Exibindo informações do pedido
            Console.WriteLine($"Pedido #{pedido.Id}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine($"Data: {pedido.Data}");
            foreach (var item in pedido.Itens)
            {
                Console.WriteLine($"{item.Produto.Nome} - Quantidade: {item.Quantidade} - Subtotal: R${item.Subtotal:F2}");
            }

            Console.WriteLine("\n");

            // Exibindo informações do pedido do segundo cliente
            Console.WriteLine($"Pedido #{pedido2.Id}");
            Console.WriteLine($"Cliente: {pedido2.Cliente.Nome}");
            Console.WriteLine($"Data: {pedido2.Data}");
            foreach (var item in pedido2.Itens)
            {
                Console.WriteLine($"{item.Produto.Nome} - Quantidade: {item.Quantidade} - Subtotal: R${item.Subtotal:F2}");
            }

            Console.WriteLine("\n");

            //valores finais do cliente 1
            Console.WriteLine($"\ncliente a pagar: {pedido.Cliente.Nome}");
            Console.WriteLine($"Subtotal: R${pedido.ValorTotal:F2}");
            Console.WriteLine($"Desconto: R${descontoTotal:F2}");
            Console.WriteLine($"Total: R${(pedido.ValorTotal - descontoTotal):F2}");

            //valores finais do cliente 2
            Console.WriteLine($"\ncliente a pagar: {pedido2.Cliente.Nome}");
            Console.WriteLine($"Subtotal: R${pedido2.ValorTotal:F2}");
            Console.WriteLine($"Desconto: R${descontoTotal2:F2}");
            Console.WriteLine($"Total: R${(pedido2.ValorTotal - descontoTotal2):F2}");

            while (true)
            {
                Console.Write($"deseja pagar a compra {pedido.Cliente.Nome} (s/n)?");
                var result = Console.ReadLine();
                if (result == "s")
                {
                    pedido.RemoverItem(1);
                    Console.WriteLine($"total: R${pedido.ValorTotal:F2}");
                    break;
                }
                else
                {
                    Console.WriteLine("ops!, voce é obrigado a pagar!!!");
                }
            }

            Console.WriteLine("=========== FIM DO CODIGO ==============");
            
        }
    }
}