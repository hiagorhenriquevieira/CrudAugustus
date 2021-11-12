using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.View.Alteracao;
using System;

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

        public void AtivarProduto (ProdutoModel produto)
        {
            try
            {
                _produtoDao.AtivarProduto(produto);
            }
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }


        public void DesativarProduto(ProdutoModel produto)
        {
            try
            {
                _produtoDao.DesativarProduto(produto);
            }
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }


    }
}
