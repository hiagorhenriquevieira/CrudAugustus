using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    class ColaboradorModel : UsuarioModel
    {
        public int IdColaborador { get; set; }
        public int Salario { get; set; }
        public int PorcentagemComissao { get; set; }
        public ContaBancariaModel Conta { get; set; }
        public ContaBancariaModel Agencia { get; set; }
        public ContaBancariaModel Banco { get; set; }
        public ContaBancariaModel TipoConta { get; set; }

    }
}
