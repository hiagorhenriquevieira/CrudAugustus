using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace CrudAugustusFashion.Extencion
{
    static class ValidacoesExtencion
    {
        public static bool NuloOuVazio(this TextBox textoBox) =>
            string.IsNullOrEmpty(textoBox.Text);

        public static bool NuloOuVazio(this MaskedTextBox mascaraBox) =>
            string.IsNullOrEmpty(mascaraBox.Text);

        public static bool NuloOuVazio(this ComboBox comboBox) =>
           string.IsNullOrEmpty(comboBox.Text);

        public static bool ValidarApenasNumeros(this string numero) =>
            !new Regex(@"^[0-9]+$").Match(numero).Success;

        public static bool ValidarStrings(this string valor) =>   
            !new Regex(@"^[a-zA-Z]+$").Match(valor).Success;

        public static bool ValidarEmail(this string email) => 
            new Regex(@"^[a-zA-Z0-9._-]+[@][a-z]+[.][a-zA-Z]{2},{3}").Match(email).Success;


    }

    
}
