using CrudAugustusFashion.Model.Endereco.CEPs;
using System.Collections.Generic;

namespace CrudAugustusFashion.Model
{
    public class EnderecoModel
    {
        List<string> _mensagens;
        public EnderecoModel(string cep, string logradouro, int numero, string cidade, string uf, string complemento, string bairro)
        {
            Cep = cep;
            Logradouro = logradouro;
            NumeroResidencia = numero;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            Bairro = bairro;
        }
        public EnderecoModel()
        {
            _mensagens = new List<string>();
        }
        public int IdUsuario { get; set; }
        public int IdEndereco { get; set; }
        public Cep Cep { get; set; }
        public string Logradouro { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int NumeroResidencia { get; set; }
        public string Cidade{ get; set; }
        public override string ToString()
        {
            return $"Cep: {Cep.RetornarComFormatacao} Rua: {Logradouro}, Nº{NumeroResidencia}, Estado: {Uf}, Complemento: {Complemento}, Bairro: {Bairro}, Cidade: {Cidade}";
        }
    }
}
