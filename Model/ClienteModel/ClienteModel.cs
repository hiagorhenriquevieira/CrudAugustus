using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Usuario;

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
    }
}
