using CrudAugustusFashion.Model.RelatorioCliente;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrudAugustusFashion.Validacoes
{
    public static class ValidacoesExtencion
    {
        public static int ToInt(this string value)
        {
            try
            {
                return int.Parse(value);
            }
            catch
            {
                return 0;
            }
        }

        public static float ToFloat(this string value)
        {
            try
            {
                return float.Parse(value);
            }
            catch
            {
                return 0f;
            }
        }

        public static bool NuloOuVazio(this TextBox textoBox) =>
            string.IsNullOrEmpty(textoBox.Text);
        public static bool NuloOuVazio(this Label label) =>
            string.IsNullOrEmpty(label.Text);

        public static bool NuloOuVazio(this MaskedTextBox mascaraBox) =>
            string.IsNullOrEmpty(mascaraBox.Text);

        public static bool NuloOuVazio(this ComboBox comboBox) =>
           string.IsNullOrEmpty(comboBox.Text);

        public static bool ValidarApenasNumeros(this string numero) =>
            new Regex(@"^[0-9aA-zZ/ ]+$").Match(numero).Success;

        public static bool ValidarApenasLetras(this string texto) =>
            new Regex(@"^[a-zA-ZçÇ áÁãÃÂâêÊ.íìÌÍ&!@#$¨*()+|\/?;>`<]+$").Match(texto).Success;

        public static bool ValidarEmail(this string email) =>
            new Regex(@"^[a-zA-Z0-9._-]+[@][a-z]+[.]([a-zA-Z]{2,3})+$").Match(email).Success;

        public static bool ValidarCpf(this string cpf) =>
            new Regex(@"^[0-9]{11}$").Match(cpf).Success;

        public static bool ValidarTelefone(this string telefone) =>
            new Regex(@"^[0-9]{10}$").Match(telefone).Success;

        public static bool ValidarCelular(this string celular) =>
            new Regex(@"^[0-9]{11}$").Match(celular).Success;

        
        public static string RetornarApenasNumeros(string valor)
        {
            return new string((from c in valor
                               where char.IsDigit(c)
                               select c).ToArray());
        }
    }
}
