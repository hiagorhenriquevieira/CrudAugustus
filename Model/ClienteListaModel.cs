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
       
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public decimal ValorLimite { get; set; }
        public string Observacao { get; set; }

        public int IdEndereco { get; set; }

        [Browsable(false)]
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
        
        [Browsable(false)]
        public TelefoneModel Telefone { get; set; }

        [DisplayName("Telefone")]
        public string TelefoneTelefone => Telefone.Telefone;
        
        [DisplayName("Celular")]
        public string TelefoneCelular => Telefone.Celular;
        
        public int IdTelefone { get; set; }

        public int IdCelular { get; set; }
    }
}
