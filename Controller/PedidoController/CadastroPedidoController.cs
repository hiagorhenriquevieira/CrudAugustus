using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Pedido;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Cadastro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrudAugustusFashion.Controller.PedidoController
{
    class CadastroPedidoController
    {
        private PedidoDao _pedidoDao;
        private VendaDao _vendaDao;
        private FrmCadastroPedido _frmCadastroPedido;

        public CadastroPedidoController()
        {
            _pedidoDao = new PedidoDao();
            _vendaDao = new VendaDao();
        }
        public void AbrirCadastroPedido()
        {
            _frmCadastroPedido = new FrmCadastroPedido(new VendaModel());
            _frmCadastroPedido.MdiParent = MdiSingletonModel.InstanciarMDI();
            _frmCadastroPedido.Show();
        }

        public void AbrirAlteracaoDePedido(VendaModel venda)
        {
            _frmCadastroPedido = new FrmCadastroPedido(venda);
            _frmCadastroPedido.MdiParent = MdiSingletonModel.InstanciarMDI();
            _frmCadastroPedido.Show();
        }

        public IList<ProdutoLista> ListarProdutosPedido(string nome)
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

        public void CadastrarPedido(VendaModel pedido)
        {
            try
            {
                _vendaDao.CadastrarVendaPedido(pedido);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
