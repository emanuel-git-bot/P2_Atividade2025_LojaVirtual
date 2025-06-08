using System;

namespace LojaVirtual
{
    public class ItemPedido
    {
        public IProduto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => Produto.Preco * Quantidade;
    }
} 