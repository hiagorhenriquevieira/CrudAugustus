using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto.Pedido;
using CrudAugustusFashion.Model.Venda;
using CrudAugustusFashion.View.Lista;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public IList<PedidoListaModel> MostrarProdutosNaLista(string nome, bool ativo)
        {
            try
            {
                var lista = _vendaDao.ListarPedidosCadastrados(nome, ativo);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro." + excecao.Message);
            }
            return new List<PedidoListaModel>();
        }
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
        public void AbrirConsultaDeVenda(VendaConsulta venda)
        {
            
            var frmConsultaLista = new FrmListaVenda(venda);
            frmConsultaLista.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmConsultaLista.Show();
        }
    }
}
