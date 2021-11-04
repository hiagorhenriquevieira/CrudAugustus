
namespace CrudAugustusFashion.Model
{
    public class EnderecoModel
    {
        public int IdUsuario { get; set; }
        public int IdEndereco { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string NumeroResidencia { get; set; }
        public string Cidade{ get; set; }
        public override string ToString()
        {
            return $"Cep: {Cep} Rua: {Logradouro}, Nº{NumeroResidencia}, Estado: {Uf}, Complemento: {Complemento}, Bairro: {Bairro}, Cidade: {Cidade}";
        }
    }
}
