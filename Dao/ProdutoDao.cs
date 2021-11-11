using CrudAugustusFashion.Model.Produto;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    public class ProdutoDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public void CadastrarProduto(ProdutoModel produto)
        {
            const string insertProduto = @"insert into Produtos (CodigoDeBarras, Nome, PrecoCusto, PrecoVenda, Lucro, QuantidadeEstoque, Fabricante)
                                         values (@CodigoDeBarras, @Nome, @PrecoCusto, @PrecoVenda, @Lucro, @QuantidadeEstoque, @Fabricante)"; 
            
            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    conexao.Execute(insertProduto, produto);
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<ProdutoModel> ListarPruduto()
        {
            const string listaProduto = @"select * from Produtos
                                          where Status = 1";

            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    
                    return conexao.Query<ProdutoModel>(listaProduto).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }




        //public void RecuperarDadosProduto(int idProduto)
        //{
        //    var selectProdutos = @"Select ";
        //}
    }
}
