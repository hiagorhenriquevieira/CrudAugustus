using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAugustusFashion.View;
using CrudAugustusFashion.View.Alteracao;

namespace CrudAugustusFashion.Controller
{
    
    public class CadastroClienteController
    {
        private ClienteDao _clienteDao;

        public CadastroClienteController()
        {
            _clienteDao = new ClienteDao();
        }

        public void CadastrarCliente(ClienteModel cliente)
        {
           _clienteDao.CadastrarCliente(cliente);
        }

        public void AbrirCadastroCliente()
        {
            var frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroCliente.Show();
        }

        public void AbrirListaCliente()
        {
            var frmListaCliente = new FrmListaCliente();
            frmListaCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaCliente.Show();
        } 
        
    }
}
