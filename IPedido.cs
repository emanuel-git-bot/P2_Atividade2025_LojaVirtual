using System;
using System.Collections.Generic;

namespace LojaVirtual
{
    public interface IPedido
    {
        int Id { get; set; }
        ICliente Cliente { get; set; }
        List<ItemPedido> Itens { get; set; }
        DateTime Data { get; set; }
        decimal ValorTotal { get; }
        void AdicionarItem(Produto produto, int quantidade);
        void RemoverItem(int produtoId);
        void CalcularValorTotal();
    }
} 