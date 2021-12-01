using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Pedido;
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
                
                mensagem = $"{NomeCompleto} está fazendo aniversário hoje.";
            }         
            return mensagem;
        }


        public string RecuperarValorGastoAPrazo(ClienteModel idCliente, VendaModel venda)
        {
            var valorAtualCliente = new ClienteDao().RecuperarValorGastoAPrazo(venda);

            var cliente = new ClienteDao().RecuperarDadosCliente(Convert.ToInt32(idCliente));

            var valorParaConsumir = Convert.ToDecimal(valorAtualCliente) - cliente.ValorLimite;

            return valorParaConsumir.ToString();
        }
    }
}
