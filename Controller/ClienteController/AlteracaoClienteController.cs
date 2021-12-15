using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Pedido;
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

        public List<ClienteListaModel> BuscarListaCliente(string nome, bool ativo)
        {
            try
            {
                var lista = _clienteDao.BuscarListaCliente(nome, ativo);
                return lista;
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public void ExibirIdadeCliente()
        {

        }

        internal ClienteModel RecuperarDadosDoCliente(int idCliente)
        {
            try
            {
                var cliente = new ClienteDao().RecuperarDadosCliente(idCliente);
                cliente.ValorConsumido = new ClienteDao().RecuperarValorGastoAPrazo(idCliente);

                return cliente;
            }
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
