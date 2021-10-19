using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Controller
{
    class CadastroClienteController
    {
        public void CadastrarCliente()
        {
            
        }
        public void AbrirCadastroCliente()
        {
            var frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroCliente.Show();
        }
    }
}
