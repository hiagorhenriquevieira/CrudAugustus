using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Lista;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrudAugustusFashion.Controller.ProdutoController
{
    public class ListaProdutoController
    {
        private ProdutoDao _produtoDao;

        public ListaProdutoController()
        {
            _produtoDao = new ProdutoDao();
        }

        public void AbrirListaProduto()
        {
            var frmListaProduto = new FrmListaProduto();
            frmListaProduto.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaProduto.Show();
        }

        public IList<ProdutoLista> MostrarProdutosNaLista(string nome, bool status)
        {
            try
            {
                var lista = _produtoDao.BuscarListaProduto(nome, status);
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
