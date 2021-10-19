using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAugustusFashion.Dao;

namespace CrudAugustusFashion.Model
{
    class UsuarioModel
    {

        public string NomeCompleto { get; set; }
        public int Cpf { get; set; }
        public string Sexo { get; set; }
        public string Cidade { get; set; }
        public int DataNascimento { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }

    }
}
