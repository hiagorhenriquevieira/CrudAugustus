using System;

namespace CrudAugustusFashion.Model.Usuario
{
    public abstract class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public NomeCompleto NomeCompleto { get; set; }
        public Cpf Cpf { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public TelefoneModel Telefone { get; set; }
        public EnderecoModel Endereco { get; set; }

        public UsuarioModel()
        {
            Endereco = new EnderecoModel();
            Telefone = new TelefoneModel();
            NomeCompleto = new NomeCompleto();
        }
    }
}
