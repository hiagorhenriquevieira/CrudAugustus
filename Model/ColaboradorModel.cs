using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    public class ColaboradorModel : UsuarioModel
    {
        public int IdColaborador { get; set; }
        public int Salario { get; set; }
        public int PorcentagemComissao { get; set; }
        public ContaBancariaModel ContasBancarias { get; set; }
        
        public ColaboradorModel()
        {
            ContasBancarias = new ContaBancariaModel();
        }

    }
}
