using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrudAugustusFashion.Controller
{
   public class AlteracaoClienteController
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

        internal void AlterarCliente(ClienteModel cliente)
        {
            try
            {
                _clienteDao.AlterarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ClienteListaModel> BuscarListaCliente(string nome)
        {
            try
            {
                var lista = _clienteDao.BuscarListaCliente(nome);
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
    }
}
