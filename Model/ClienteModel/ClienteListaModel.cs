using CrudAugustusFashion.Model.Usuario;
using System;

namespace CrudAugustusFashion.Model
{
    public class ClienteListaModel
    {
        public int IdCliente { get; set; }
        public NomeCompleto NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }

        public EnderecoModel Endereco { get; set; }

        public TelefoneModel Telefone { get; set; }

    }
}
