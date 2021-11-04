using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
