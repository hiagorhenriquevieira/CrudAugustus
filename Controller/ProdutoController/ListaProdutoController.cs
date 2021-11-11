using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Lista;
namespace CrudAugustusFashion.Controller.ProdutoController
{
    public class ListaProdutoController
    {
        private ProdutoDao _produtoDao;

        public ListaProdutoController()
        {
            _produtoDao = new ProdutoDao();
        }

        public void AbrirListaProduto ()
        {
            var frmListaProduto = new FrmListaProduto();
            frmListaProduto.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaProduto.Show();
        }

        public void MostrarProdutosNaLista()
        {
            var produto = new ProdutoModel();
             _produtoDao.ListarPruduto();
        }
    }
}
