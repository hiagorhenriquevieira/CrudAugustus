using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;


namespace CrudAugustusFashion.Controller
{
    class AlteracaoClienteController
    {
        private ClienteDao _clienteDao;
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
            try
            {
                _clienteDao.AlterarCliente(Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
