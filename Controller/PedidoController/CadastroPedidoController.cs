using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Cadastro;
using CrudAugustusFashion.View.Lista;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrudAugustusFashion.Controller.PedidoController
{
    class CadastroPedidoController
    {
        private PedidoDao _pedidoDao;

        public CadastroPedidoController()
        {
            _pedidoDao = new PedidoDao();
        }
        public void AbrirCadastroPedido()
        {
            var frmCadastroPedido = new FrmCadastroPedido();
            frmCadastroPedido.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroPedido.Show();
        }

        public IList<ProdutoLista> ListarProdutosParaVenda(string nome)
        {
            try
            {
                var lista = _pedidoDao.BuscarProdutoParaVenda(nome);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro." + excecao.Message);
            }
            return new List<ProdutoLista>();
        }
        
        public void AbrirListaParaVenda()
        {
            var frmPedidoLista = new FrmPedidoLista();
            frmPedidoLista.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmPedidoLista.Show();
        }
    }
}
