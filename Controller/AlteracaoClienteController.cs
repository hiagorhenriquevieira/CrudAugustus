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
        public void AbrirAlteracaoCliente(ClienteModel cliente)
        {
            var frmAlteracaoCliente = new FrmAlteracaoCliente(cliente);
            frmAlteracaoCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoCliente.Show();

        }
        public void AlterarCliente()
        {
            
        }


        
    }
}
