using System;

namespace LojaVirtual
{
    public interface IPedidoFactory
    {
        IPedido CriarPedido(ICliente cliente);
    }
} 