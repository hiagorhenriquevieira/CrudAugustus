using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto.Pedido;
using CrudAugustusFashion.View.Lista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Controller.PedidoController
{
   public class ListagemPedidoController
    {
        private VendaDao _vendaDao;

        public ListagemPedidoController()
        {
            _vendaDao = new VendaDao();
        }

        public void AbrirListaPedido()
        {
            _frmPedidoLista = new FrmPedidoLista();
            _frmPedidoLista.MdiParent = MdiSingletonModel.InstanciarMDI();
            _frmPedidoLista.Show();
        }

        //public void ListarPedidosRealizados(PedidoListaModel pedidoLista)
        //{
        //    try
        //    {
        //        _vendaDao.ListarPedidosCadastrados(pedidoLista);
        //    }
        //    catch (Exception excecao)
        //    {
        //        throw new Exception(excecao.Message);
        //    }

        //}
    }
}
