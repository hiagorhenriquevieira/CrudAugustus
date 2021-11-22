using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Lista;

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
           var frmPedidoLista = new FrmPedidoLista();
            frmPedidoLista.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmPedidoLista.Show();
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
