using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Cadastro;
using System;

namespace CrudAugustusFashion.Controller.ProdutoController
{
    public class CadastroProdutoController
    {
        private ProdutoDao _produtoDao;

        public CadastroProdutoController()
        {
            _produtoDao = new ProdutoDao();
        }
        public void AbrirCadastroProduto()
        {
            var frmCadastroProduto = new FrmCadastroProduto();
            frmCadastroProduto.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroProduto.Show();
        }
        public void CadastrarProduto(ProdutoModel produtoModel)
        {
            try
            {
                _produtoDao.CadastrarProduto(produtoModel);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
