using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto.Pedido;
using CrudAugustusFashion.Model.Venda;
using CrudAugustusFashion.View.Lista;
using System;

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
        //        _vendaDao.ListarPedidosCadastrados();
        //    }
        //    catch (Exception excecao)
        //    {
        //        throw new Exception(excecao.Message);
        //    }

        //}
        public VendaConsulta ExibirListaDeVenda(int idVenda)
        {
            try
            {
                return _vendaDao.ExibirPedidoSelecionado(idVenda);
            }
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
            
        }
        public void AbrirConsultaDeVenda()
        {
            
            var frmConsultaLista = new FrmListaVenda();
            frmConsultaLista.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmConsultaLista.Show();
        }
    }
}
