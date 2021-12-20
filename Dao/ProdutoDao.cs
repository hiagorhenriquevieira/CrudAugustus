using CrudAugustusFashion.Model.Produto;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    public class ProdutoDao
    {
        public void CadastrarProduto(ProdutoModel produto)
        {
            const string insertProduto = @"insert into Produtos (CodigoDeBarras, Nome, PrecoCusto, PrecoVenda, Lucro, QuantidadeEstoque, Fabricante)
                                         values (@CodigoDeBarras, @Nome, @PrecoCusto, @PrecoVenda, @Lucro, @QuantidadeEstoque, @Fabricante)";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    conexao.Execute(insertProduto, new
                    {
                        produto.CodigoDeBarras,
                        produto.Nome,
                        PrecoCusto = produto.PrecoCusto.Valor,
                        PrecoVenda = produto.PrecoVenda.Valor,
                        produto.Lucro,
                        produto.QuantidadeEstoque,
                        produto.Fabricante,
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal ProdutoModel RecuperarDadosProduto(int IdProduto)
        {
            const string selectProduto = @"select * from Produtos
                                           where IdProduto = @IdProduto";
            try
            {
                using (var conexao = ConexaoDao.conectar())
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
                using (var conexao = ConexaoDao.conectar())
                {
                    conexao.Execute(updateProduto, new
                    {
                        produto.IdProduto,
                        produto.CodigoDeBarras,
                        produto.Nome,
                        PrecoCusto = produto.PrecoCusto.Valor,
                        PrecoVenda = produto.PrecoVenda.Valor,
                        produto.Lucro,
                        produto.QuantidadeEstoque,
                        produto.Fabricante

                    });
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
                using (var conexao = ConexaoDao.conectar())
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
                using (var conexao = ConexaoDao.conectar())
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
            using (var conexao = ConexaoDao.conectar())
            {
                return conexao.Query<ProdutoLista>(selectProduto, new { Nome = nome, Status = status }).ToList();
            }
        }
    }
}
