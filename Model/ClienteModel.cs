using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    public class ClienteModel : UsuarioModel
    {
        public int IdCliente { get; set; }
        public string Observacao{ get; set; }
        public decimal ValorLimite { get; set; }
        
    }
}
