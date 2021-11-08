using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Cliente;
using System;

namespace CrudAugustusFashion.Controller
{
    public class ExcluirClienteController
    {
        private ClienteDao _clienteDao;
        public ExcluirClienteController()
        {
            _clienteDao = new ClienteDao();
        }
        public void ExcluirClientes(ClienteModel clienteModel)
        {
            try
            {
               _clienteDao.ExcluirClientes(clienteModel);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
