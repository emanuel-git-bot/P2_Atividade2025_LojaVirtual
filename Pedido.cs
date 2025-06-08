using System;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual
{
    public class Pedido : IPedido
    {
       public int Id { get; set; }
        public ICliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; private set; }

        public Pedido(int id, ICliente cliente)
        {
            Id = id;
            Cliente = cliente;
            Itens = new List<ItemPedido>();
            Data = DateTime.Now;
         }

        public void AdicionarItem(Produto produto, int quantidade)
        {
            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            var itemExistente = Itens.FirstOrDefault(i => i.Produto.Id == produto.Id);
            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
            }
            else
            {
                Itens.Add(new ItemPedido(produto, quantidade));
            }

            CalcularValorTotal();
        }

        public void RemoverItem(int produtoId)
        {
            var item = Itens.FirstOrDefault(i => i.Produto.Id == produtoId);
            if (item != null)
            {
                Itens.Remove(item);
                CalcularValorTotal();
            }
        }

        public void CalcularValorTotal()
        {
            ValorTotal = Itens.Sum(item => item.Subtotal);
        }
    }
} 