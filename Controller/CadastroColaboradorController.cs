using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View;

namespace CrudAugustusFashion.Controller
{
    class CadastroColaboradorController
    {
        public void AbrirCadastroColaborador()
        {
            var frmCadastroColaborador = new FrmCadastroColaborador();
            frmCadastroColaborador.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroColaborador.Show();
        }
    }
}
