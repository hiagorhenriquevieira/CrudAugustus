using CrudAugustusFashion.Model.Usuario;
using System;
using System.ComponentModel;

namespace CrudAugustusFashion.Model
{
    public class ClienteListaModel
    {
        [DisplayName ("Código cliente")]
        public int IdCliente { get; set; }
        [DisplayName ("Nome")]
        public NomeCompleto NomeCompleto { get; set; }
        [DisplayName ("Sexo")]
        public string Sexo { get; set; }
        [DisplayName ("Idade")]
        public int Idade
        {
            get
            {
                if (DataNascimento.DayOfYear <= DateTime.Now.DayOfYear)
                    return DateTime.Now.Year - DataNascimento.Year;

                return DateTime.Now.Year - DataNascimento.Year - 1;
            }
        }

        [DisplayName ("Data nascimento")]
        public DateTime DataNascimento { get; set; }
        [DisplayName ("Endereço")]
        public EnderecoModel Endereco { get; set; }
        [DisplayName ("Telefone")]
        public TelefoneModel Telefone { get; set; }
    }
}
