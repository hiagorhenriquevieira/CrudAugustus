using System;
using System.Linq;

namespace CrudAugustusFashion.Model.Carinho
{
    public static class ValidacaoDePreco
    {
        public static string RemoverFormatacaoDoPreco(this string valor)
        {
            string precoSemFormatacao = valor;

            precoSemFormatacao = new string((from c in precoSemFormatacao
                                             where char.IsDigit(c)
                                           select c).ToArray());

            var precoCorreto = (Convert.ToInt32(precoSemFormatacao)/100);
            return precoCorreto.ToString();
        }
    }
}
