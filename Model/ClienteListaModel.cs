using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    public class ClienteListaModel
    {


        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }

        public EnderecoModel Endereco { get; set; }

        public TelefoneModel Telefone { get; set; }

    }
}
