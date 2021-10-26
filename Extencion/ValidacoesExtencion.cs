using NetTopologySuite.Algorithm;
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

        public static bool ValidarcampoCpf(this MaskedTextBox mascaraBox)
        {
            if (mascaraBox.TextLength != 11)
            {
            }
            return true;
        }

        public static bool ValidarCampoCep(this MaskedTextBox mascaraBox)
        {
            if (mascaraBox.TextLength != 8)
            {

            }
            return true;
        }



        public static bool ValidarCampoCelular(this MaskedTextBox mascaraBox)
        {
            if (mascaraBox.TextLength != 11) { }
            return true;
        }
        public static bool ValidarCampoNumeroResidencia(this TextBox textoBox)
        {
            return true;
        }
    }
}
