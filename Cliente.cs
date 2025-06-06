using System;
using System.Text.RegularExpressions;

namespace LojaVirtual
{
    public class Cliente : ICliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public bool Validar()
        {

            return true;
        }

    }
} 