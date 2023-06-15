using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class ClienteModel : PessoaModel
    {
        public int Nif { get; set; }
        public List<BilheteModel> ListaBilhetes { get; set; }

        public ClienteModel() : base() { }

        public ClienteModel(string name, string morada, int nif) : base(name, morada)
        {
            Nif = nif;
            ListaBilhetes = new List<BilheteModel>();
        }

        public void AdicionarBilhete(BilheteModel bilhete)
        {
            ListaBilhetes.Add(bilhete);
        }

        /**
         * @brief Verifica se um determinado NIF é válido calculando o dígito de controlo
         *
         * O algoritmo de validação do NIF foi adaptado de:
         * - https://pt.wikipedia.org/wiki/N%C3%BAmero_de_identifica%C3%A7%C3%A3o_fiscal
         *
         * Segundo a documentação, o check digit é calculado da seguinte forma:
         *  1 - Multiplicar o 8º digito por 2, o 7º por 3, o 6º por 4, o 5º por 5, o 4º por 6, o 3º por 7, o 2º por 8 e o 1º por 9.
         *  2 - Somar os resultados obtidos.
         *  3 - Calcular o resto da divisão do número por 11.
         *      3.1 - Se o resto for 0 ou 1 o check digit será 0.
         *      3.1 - Se for outro qualquer algarismo X, o check digit será 11 - X.
         *
         * @param nif
         * @return
         */
        public static bool NifValido(int nif)
        {
            int checkDigit = nif % 10;
            int soma = 0;
            int multiplicador = 2;
            int resto;

            nif /= 10;

            for (int i = 0; i < 8; i++) {
                soma += (nif % 10) * multiplicador;
                nif /= 10;
                multiplicador++;
            }

            resto = soma % 11;
            if (resto == 0 || resto == 1) return checkDigit == 0;
            else return checkDigit == 11 - resto;
        }
    }
}
