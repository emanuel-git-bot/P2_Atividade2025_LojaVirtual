using System;


namespace LojaVirtual{
    class Program
    {
        static void Main(string[] args)
        {
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

            // Criando cliente
            var cliente = new Cliente(1, "emanuel roque", "emanuel@email.com", "123.456.789-00");
        }
    }
}