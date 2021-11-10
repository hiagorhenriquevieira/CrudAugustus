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
            //try
            //{
            //    var retorno = produtoModel.ValidarProduto();

            //    if (retorno == string.Empty)
            //    {
                   _produtoDao.CadastrarProduto(produtoModel);
            //    }
            //    return retorno;
            //}
            //catch (Exception excecao)
            //{
            //    throw new Exception(excecao.Message);
            //}
        }

    }
}
