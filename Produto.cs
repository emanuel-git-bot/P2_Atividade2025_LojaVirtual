using System;

namespace LojaVirtual
{
    public class Produto : IProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                return false;
            
            if (Preco <= 0)
                return false;
            
            if (string.IsNullOrWhiteSpace(Categoria))
                return false;

            return true;
        }

    }
} 