using System;

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

        public UsuarioModel()
        {
            Endereco = new EnderecoModel();
            Telefone = new TelefoneModel();
        }
    }
}
