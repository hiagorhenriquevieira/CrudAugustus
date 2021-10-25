﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    public class ColaboradorListaModel
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int IdColaborador { get; set; }
        public int Salario { get; set; }
        public int PorcentagemComissao { get; set; }
        public ContaBancariaModel ContaBancaria { get; set; }
        public int IdContaBancaria { get; set; }

        [DisplayName("Conta")]
        public int ContaBancariaConta => ContaBancaria.Conta;
        public string ContaBancariaBanco => ContaBancaria.Banco;
        public string ContaBancariaTipoConta => ContaBancaria.TipoConta;
        public int ContaBancariaAgencia => ContaBancaria.Agencia;

        public int IdEndereco { get; set; }

        public EnderecoModel Endereco { get; set; }

        [DisplayName("CEP")]
        public string EnderecoCep => Endereco.Cep;

        [DisplayName("Logradouro")]
        public string EnderecoLogradouro => Endereco.Logradouro;

        [DisplayName("Número")]
        public string EnderecoNumero => Endereco.NumeroResidencia.ToString();

        [DisplayName("Cidade")]
        public string EnderecoCidade
        {
            get => Endereco.Cidade;
        }
        [DisplayName("Estado")]
        public string EnderecoUF
        {
            get => Endereco.Uf;
        }
        [DisplayName("Complemento")]
        public string EnderecoComplemento
        {
            get => Endereco.Complemento;
        }
        [DisplayName("Bairro")]
        public string EnderecoBairro
        {
            get => Endereco.Bairro;
        }

        public TelefoneModel Telefone { get; set; }

        [DisplayName("Telefone")]
        public string TelefoneTelefone
        {
            get => Telefone.Telefone;
        }
        [DisplayName("Celular")]
        public string TelefoneCelular
        {
            get => Telefone.Celular;
        }
        public int IdTelefone { get; set; }

        public int IdCelular { get; set; }

    }
}