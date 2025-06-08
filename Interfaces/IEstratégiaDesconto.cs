using System;

namespace LojaVirtual
{
  public interface IDescontoStrategy
    {
       decimal CalcularDesconto(IPedido pedido);
    }
} 