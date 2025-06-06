using System;

namespace LojaVirtual
{
    public interface ICliente
    {
      public interface ICliente
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Email { get; set; }
        string CPF { get; set; }
        bool Validar();
    }
    }
} 