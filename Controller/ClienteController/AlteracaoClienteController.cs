using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
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

        internal string AlterarCliente(ClienteModel clienteModel)
        {
            try
            {
                var retorno = clienteModel.ValidarCliente();
                if (retorno == string.Empty)
                {
               _clienteDao.AlterarCliente(clienteModel);
                }
                return retorno;
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
