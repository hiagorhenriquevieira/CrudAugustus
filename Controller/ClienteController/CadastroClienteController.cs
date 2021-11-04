using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using System;
using CrudAugustusFashion.View;

namespace CrudAugustusFashion.Controller
{
    
    public class CadastroClienteController
    {
        private ClienteDao _clienteDao;

        public CadastroClienteController()
        {
            _clienteDao = new ClienteDao();
        }

        public void CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                _clienteDao.CadastrarCliente(clienteModel);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
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
