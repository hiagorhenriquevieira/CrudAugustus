﻿using CrudAugustusFashion.Model.Usuario;
using System;

namespace CrudAugustusFashion.Model
{
    public class ClienteListaModel
    {
        public int IdCliente { get; set; }
        public NomeCompleto NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public int Idade
        {
            get
            {
                if (DataNascimento.DayOfYear <= DateTime.Now.DayOfYear)
                    return DateTime.Now.Year - DataNascimento.Year;

                return DateTime.Now.Year - DataNascimento.Year - 1;

            }
        }

        public DateTime DataNascimento { get; set; }
        public EnderecoModel Endereco { get; set; }
        public TelefoneModel Telefone { get; set; }
    }
}
