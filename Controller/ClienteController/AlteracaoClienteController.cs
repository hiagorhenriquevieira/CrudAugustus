using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;


namespace CrudAugustusFashion.Controller
{
   public class AlteracaoClienteController
    {
        private ClienteDao _clienteDao;
        public AlteracaoClienteController()
        {
            _clienteDao = new ClienteDao();
        }

        public void AbrirAlteracaoCliente(ClienteModel clienteModel)
        {
            var frmAlteracaoCliente = new FrmAlteracaoCliente(clienteModel);
            frmAlteracaoCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoCliente.Show();

        }

        internal void AlterarCliente(ClienteModel clienteModel)
        {
            try
            {
                _clienteDao.AlterarCliente(clienteModel);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }

        }

        public List<ClienteListaModel> BuscarListaCliente(string nome)
        {
            try
            {
                var lista = _clienteDao.BuscarListaCliente(nome);
                return lista;
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
                
            }
        }
    }
}
