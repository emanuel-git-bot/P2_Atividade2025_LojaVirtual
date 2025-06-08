using System;

namespace LojaVirtual
{
    public interface IClienteFactory
    {
        ICliente CriarCliente(string nome, string email, string cpf);
    }
} 