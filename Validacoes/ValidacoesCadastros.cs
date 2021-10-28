using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Validacoes
{
    public static class ValidacoesCadastros
    {
        public static bool ValidarSeStringNaoPossuiNumeros(string nome) => !nome.ValidarApenasLetras();

        public static bool ValidarSeIntNaoPossuiLetras(string numero) => !numero.ValidarApenasNumeros();
    }
}
