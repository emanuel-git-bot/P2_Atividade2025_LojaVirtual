using System;
using System.Linq;

namespace LojaVirtual
{
    public class DescontoPorQuantidadeStrategy : IDescontoStrategy
    {
        private readonly int _quantidadeMinima;
        private readonly decimal _percentualDesconto;

        public DescontoPorQuantidadeStrategy(int quantidadeMinima, decimal percentualDesconto)
        {
            _quantidadeMinima = quantidadeMinima;
            _percentualDesconto = percentualDesconto;
        }

        public decimal CalcularDesconto(IPedido pedido)
        {
            var itensComQuantidadeMinima = pedido.Itens
                .Where(i => i.Quantidade >= _quantidadeMinima)
                .Sum(i => i.Subtotal);

            return itensComQuantidadeMinima * (_percentualDesconto / 100);
        }
    }
} 