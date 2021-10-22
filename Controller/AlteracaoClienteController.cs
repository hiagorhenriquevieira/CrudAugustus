using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.Controller
{
    class AlteracaoClienteController
    {
        public void AbrirAlteracaoCliente()
        {
            var frmAlteracaoCliente = new FrmAlteracaoCliente();
            frmAlteracaoCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoCliente.Show();

        }
        public void AlterarCliente()
        {
            
        }


        
    }
}
