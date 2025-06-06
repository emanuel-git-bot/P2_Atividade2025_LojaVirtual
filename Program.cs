using System;


namespace LojaVirtual{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando produtos
            var produto1 = new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Preco = 3500.00m,
                Categoria = "Eletrônicos"
            };

            var produto2 = new Produto
            {
                Id = 2,
                Nome = "Mouse",
                Preco = 50.00m,
                Categoria = "Acessórios"
            };

            Console.WriteLine(produto1.Id);
            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
            Console.WriteLine(produto1.Categoria);

            Console.WriteLine(produto2.Id);
            Console.WriteLine(produto2.Nome);
            Console.WriteLine(produto2.Preco);
            Console.WriteLine(produto2.Categoria);
        }
    }
}