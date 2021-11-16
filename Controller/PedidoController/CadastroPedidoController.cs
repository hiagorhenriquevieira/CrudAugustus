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
        private FrmCadastroPedido _frmCadastroPedido;

        public CadastroPedidoController()
        {
            _pedidoDao = new PedidoDao();
        }
        public void AbrirCadastroPedido()
        {
            _frmCadastroPedido = new FrmCadastroPedido();
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
    }
}
