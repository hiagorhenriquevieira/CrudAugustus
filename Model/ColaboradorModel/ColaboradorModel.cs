using CrudAugustusFashion.Model.Usuario;
using System;

namespace CrudAugustusFashion.Model
{
    public class ColaboradorModel : UsuarioModel
    {
        public int IdColaborador { get; set; }
        public int Salario { get; set; }
        public int PorcentagemComissao { get; set; }
        public ContaBancariaModel ContasBancarias { get; set; }
        public bool Ativo { get; set; }
        public string ValidarColaborador()
        {
            var retorno = new ColaboradorValidation().Validate(this);
            if (retorno.IsValid)
                return string.Empty;

            return retorno.ToString();
        }
        public ColaboradorModel()
        {
            ContasBancarias = new ContaBancariaModel();
        }
        public string VerificarSeEhAniversarioDoCliente()
        {

            var mensagem = string.Empty;

            if (DataNascimento.Month == DateTime.Now.Month && DataNascimento.Day == DateTime.Now.Day)
            {
                mensagem = $"{NomeCompleto.Nome} está fazendo aniversário hoje.";
            }
            return mensagem;
        }
    }
}
