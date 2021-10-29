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
            try
            {
                _clienteDao.CadastrarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
