using System;

namespace LojaVirtual
{
    public interface IProduto
    {
        int Id { get; set; }
        string Nome { get; set; }
        decimal Preco { get; set; }
        string Categoria { get; set; }
        bool Validar();
    }
} 