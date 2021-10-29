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
        private  ClienteDao _clienteDao;
        public AlteracaoClienteController()
        {
            _clienteDao = new ClienteDao();
        }

        public void AbrirAlteracaoCliente(ClienteModel cliente)
        {
            var frmAlteracaoCliente = new FrmAlteracaoCliente(cliente);
            frmAlteracaoCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoCliente.Show();

        }

        internal void AlterarCliente(ClienteModel Cliente)
        {
            _clienteDao.AlterarCliente(Cliente);
        }
    }
}
