using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    class ClienteModel : UsuarioModel
    {
        public int Id { get; set; }
        public int Observacao{ get; set; }
        public int LimiteCompra { get; set; }
        
    }
}
