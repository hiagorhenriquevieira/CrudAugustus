using CrudAugustusFashion.Model.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    public class ColaboradorListaModel
    {
        public int IdColaborador { get; set; }
        public NomeCompleto NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public EnderecoModel Endereco { get; set; }
        public TelefoneModel Telefone { get; set; }


    }
}
