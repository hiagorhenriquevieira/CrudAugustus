using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
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

        public string CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                var retorno = clienteModel.ValidarCliente();
                if (retorno == string.Empty)
                {
                _clienteDao.CadastrarCliente(clienteModel);
                    return string.Empty;
                }else
                {
                    return retorno;     
                }
                
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
