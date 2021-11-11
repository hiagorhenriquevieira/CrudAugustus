using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Alteracao;

namespace CrudAugustusFashion.Controller.ProdutoController
{
    class AlteracaoProdutoController
    {
        private ProdutoDao _produtoDao;

        public AlteracaoProdutoController()
        {
            _produtoDao = new ProdutoDao();
        }

        public void AbrirAlteracaoProduto(ProdutoModel produtoModel)
        { 
            var frmAlteracaoProduto = new FrmAlteracaoProduto(produtoModel);
            frmAlteracaoProduto.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoProduto.Show();

        }

        public void AlterarProduto(ProdutoModel produto)
        {
            _produtoDao.AlterarProduto(produto);
        }
    }
}
