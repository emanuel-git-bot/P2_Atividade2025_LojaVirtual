using System;

namespace LojaVirtual
{
    public class ClienteFactory : IClienteFactory
    {
        private static int _ultimoId = 0;

        public ICliente CriarCliente(string nome, string email, string cpf)
        {
            _ultimoId++;
            return new Cliente(_ultimoId, nome, email, cpf);
        }
    }
} 