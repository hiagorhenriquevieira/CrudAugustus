using CrudAugustusFashion.Model.Usuario;
using System;

namespace CrudAugustusFashion.Model.Cliente
{
    public class ClienteModel : UsuarioModel
    {
        public int IdCliente { get; set; }
        public string Observacao{ get; set; }
        public decimal ValorLimite { get; set; }
        public bool Ativo { get; set; }
        public string ValidarCliente()
        {
            var retorno = new ClienteValidation().Validate(this);
            if (retorno.IsValid) 
                return string.Empty;
             
            return retorno.ToString();
        }
        public string VerificarSeEhAniversarioDoCliente()
        {
            
            var mensagem = string.Empty;

            if (DataNascimento.Month == DateTime.Now.Month && DataNascimento.Day == DateTime.Now.Day)
            {
                TimeSpan result;
                
                mensagem = $"{NomeCompleto.Nome} está fazendo aniversário hoje.";
            }

            
            return mensagem;
        }
        
    }
}
