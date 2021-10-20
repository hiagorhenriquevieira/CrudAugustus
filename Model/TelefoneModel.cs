using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    public class TelefoneModel : UsuarioModel
    {
        public int IdTelefone { get; set; }

        public int Telefone { get; set; }
        public int DddTelefone { get; set; }
        public int DddCelular { get; set; }

        public int Celular { get; set; }

    }
}
