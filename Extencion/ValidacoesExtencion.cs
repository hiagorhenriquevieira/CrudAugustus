using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        //else if (int.TryParse(txtCep.Text))
        //{
        //    var str = txtCep.Text.ToCharArray();

        //    foreach (var s in str)
        //    {
        //        if (!Char.IsDigit(s))
        //            return false;
        //    }
        //}


    }
}
