using System;
using System.Linq;
using System.Threading.Tasks;
using TesteUnidas.Services.Interfaces;

namespace TesteUnidas.Services
{
    public class SenhaService : ISenhaService
    {
        public bool ValidarSenha(string senha)
        {
            //tamanho mínimo de 9 caracteres
            if (senha.Length < 9)
                return false;

            //verifica se há dígito
            if (!senha.Any(char.IsDigit))
                return false;

            // Ao menos 1 letra minúscula
            if (!senha.Any(char.IsLower))
                return false;

            //Ao menos 1 letra maiúscula
            if (!senha.Any(char.IsUpper))
                return false;

            //verifica se contém um caracter especial
            var caracteresEspeciais = "!@#$%^&*()-+".ToCharArray();
            if (senha.IndexOfAny(caracteresEspeciais) == -1)
                return false;

            //verifica caracteres repetidos
            if (senha.Distinct().Count() != senha.Length)
                return false;

            return true;
        }
    }
}
