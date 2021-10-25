﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAugustusFashion.Dao;

namespace CrudAugustusFashion.Model
{
    public abstract class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public TelefoneModel Telefone { get; set; }
        public EnderecoModel Endereco { get; set; }

    }
}
