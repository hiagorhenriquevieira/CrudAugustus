using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Alteracao;

namespace CrudAugustusFashion.Controller.ProdutoController
{
    class AlteracaoProdutoController
    {
        public void AbrirAlteracaoProduto(ProdutoModel produtoModel)
        { 
            var frmAlteracaoProduto = new FrmAlteracaoProduto(produtoModel);
            frmAlteracaoProduto.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoProduto.Show();

        }
    }
}
