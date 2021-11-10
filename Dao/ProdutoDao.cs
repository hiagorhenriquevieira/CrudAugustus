using CrudAugustusFashion.Model.Produto;
using Dapper;
using System;

namespace CrudAugustusFashion.Dao
{
    public class ProdutoDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public void CadastrarProduto(ProdutoModel produto)
        {
            const string insertProduto = @"insert into Produtos (CodigoDeBarras, Nome, PrecoVenda, PrecoCusto, QuantidadeEstoque, Fabricante)
                                         values (@CodigoDeBarras, @NomeProduto, @PrecoVenda, @PrecoCusto, @QuantidadeEstoque, @NomeFabricante )"; 
            
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
    }
}
