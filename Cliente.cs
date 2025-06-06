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
            if (string.IsNullOrWhiteSpace(Nome))
                return false;
            
            if (string.IsNullOrWhiteSpace(Email) || !ValidarEmail(Email))
                return false;
            
            if (string.IsNullOrWhiteSpace(CPF) || !ValidarCPF(CPF))
                return false;

            return true;
        }

        private bool ValidarEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            
            if (cpf.Length != 11)
                return false;

            return true; // Simplificação da validação de CPF para o exemplo
        }
    }
} 