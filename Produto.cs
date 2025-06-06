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
            return true;
         }

    }
} 