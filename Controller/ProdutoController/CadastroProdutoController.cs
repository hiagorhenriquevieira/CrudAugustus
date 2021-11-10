using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Cadastro;

namespace CrudAugustusFashion.Controller.ProdutoController
{
    public class CadastroProdutoController
    {
        public void AbrirCadastroProduto()
        {
            var frmCadastroProduto = new FrmCadastroProduto();
            frmCadastroProduto.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroProduto.Show();
        }

    }
}
