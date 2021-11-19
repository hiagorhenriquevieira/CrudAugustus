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
        //public List<ProdutoLista> ListarPruduto()
        //{
        //    const string listaProduto = @"select * from Produtos";
        //    using (var conexao = this.conexao.conectar())
        //    {

        //        return conexao.Query<ProdutoLista>(listaProduto).ToList();
        //    }
        //}
        //public int RecuperarIdProduto(int idProduto)
        //{
        //    const string selectIdProduto = @"select idproduto from produtos
        //                                     where idproduto = @idproduto";
        //    try
        //    {
        //        using (var conexao = this.conexao.conectar())
        //        {
        //            return conexao.QuerySingle<int>(selectIdProduto, new { idProduto });
        //        }
        //    }
        //    catch (Exception excecao)
        //    {
        //        throw new Exception(excecao.Message);
        //    }
        //}
        internal ProdutoModel RecuperarDadosProduto(int IdProduto)
        {
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
            const string updateProduto = @"update Produtos set CodigoDeBarras = @CodigoDeBarras, Nome = @Nome,
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

        public void DesativarProduto(ProdutoModel produto)
        {
            const string produtoInativo = @"update Produtos set Status = 0
	                                        where IdProduto = @IdProduto;";
            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    conexao.Execute(produtoInativo, produto);
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
        public void AtivarProduto(ProdutoModel produto)
        {
            const string produtoAtivo = @"update Produtos set Status = 1
	                                      where IdProduto = @IdProduto;";
            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    conexao.Execute(produtoAtivo, produto);
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
        public List<ProdutoLista> BuscarListaProduto(string nome, bool status)
        {
            const string selectProduto = @"Select IdProduto, CodigoDeBarras, Nome, Fabricante, PrecoCusto, PrecoVenda, QuantidadeEstoque
                                           from Produtos
                                           where Nome Like @Nome + '%' and Status = @Status ";
            using (var conexao = this.conexao.conectar())
            {
                return conexao.Query<ProdutoLista>(selectProduto, new { Nome = nome, Status = status }).ToList();
            }
        }
    }


    //public void RecuperarDadosProduto(int idProduto)
    //{
    //    var selectProdutos = @"Select ";
}
