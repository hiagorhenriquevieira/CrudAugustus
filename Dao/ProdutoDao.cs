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


        public List<ProdutoLista> ListarPruduto()
        {
            const string listaProduto = @"select * from Produtos
                                          where Status = 1";

            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    
                    return conexao.Query<ProdutoLista>(listaProduto).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public int RecuperarIdProduto(int IdProduto)
        {
            const string selectIdProduto = @"select IdProduto from Produtos
                                             where IdProduto = @IdProduto";
            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    return conexao.QuerySingle<int>(selectIdProduto, new { IdProduto });
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        internal ProdutoModel RecuperarDadosProduto(int IdProduto)
        {
            int codigoProduto = RecuperarIdProduto(IdProduto);

            const string selectProduto = @"select * from Produtos
                                           where IdProduto = @IdProduto";
            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    return conexao.Query<ProdutoModel>(selectProduto, new { IdProduto }).FirstOrDefault();
                        
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }

        }
        public void AlterarProduto(ProdutoModel produto)
        {
            const string updateProduto =@"update Produtos set CodigoDeBarras = @CodigoDeBarras, Nome = @Nome,
                                        PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda, Lucro = @Lucro, 
                                        QuantidadeEstoque = @QuantidadeEstoque, Fabricante = @Fabricante
                                        where IdProduto = @IdProduto ";
            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    conexao.Execute(updateProduto, produto);
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
