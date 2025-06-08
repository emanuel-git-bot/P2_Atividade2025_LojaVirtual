using System;

namespace LojaVirtual
{
    public class ProdutoFactory : IProdutoFactory
    {
        private static int _ultimoId = 0;

        public Produto CriarProduto(string nome, decimal preco, string categoria)
        {
            _ultimoId++;
            return new Produto(_ultimoId, nome, preco, categoria);
        }
    }
} 