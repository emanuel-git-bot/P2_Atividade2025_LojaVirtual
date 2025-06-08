using System;
using System.Linq;

namespace LojaVirtual
{
    public class DescontoPorCategoriaStrategy : IDescontoStrategy
    {
        private readonly string _categoria;
        private readonly decimal _percentualDesconto;

        public DescontoPorCategoriaStrategy(string categoria, decimal percentualDesconto)
        {
            _categoria = categoria;
            _percentualDesconto = percentualDesconto;
        }

        public decimal CalcularDesconto(IPedido pedido)
        {
            var itensCategoria = pedido.Itens
                .Where(i => i.Produto.Categoria.Equals(_categoria, StringComparison.OrdinalIgnoreCase))
                .Sum(i => i.Subtotal);

            return itensCategoria * (_percentualDesconto / 100);
        }
    }
} 