using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Produto.Pedido;
using CrudAugustusFashion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using VendaModel = CrudAugustusFashion.Model.Pedido.VendaModel;

namespace CrudAugustusFashion.Dao
{
    public class VendaDao
    {
        public void CadastrarVendaPedido(VendaModel venda)
        {
            const string insertVenda = @"Insert into Venda (IdCliente, IdColaborador, TotalBruto, TotalDesconto, TotalLiquido, Lucro, FormaDePagamento, DataEmissao)  
                output inserted.IdVenda 
                values (@IdCliente, @IdColaborador, @TotalBruto, @TotalDesconto, @TotalLiquido, @LucroTotal, @FormaDePagamento, @DataEmissao)";

            const string insertPedidoProduto = @"Insert into PedidosProduto (IdVenda, PrecoBruto, PrecoCusto, IdProduto, PrecoVenda,
                QuantidadeProduto, Desconto, PrecoLiquido,Total) 
                values (@IdVenda, @PrecoVenda, @PrecoCusto, @IdProduto, @PrecoVenda, @Quantidade, @Desconto, @PrecoLiquido, @Total)";
            const string updateQuantidade = @"Update  Produtos set QuantidadeEstoque -= @Quantidade 
                                            where IdProduto = @IdProduto";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    using (SqlTransaction transaction = conexao.BeginTransaction())
                    {
                        venda.IdVenda = conexao.ExecuteScalar<int>(insertVenda,
                            new
                            {
                                venda.IdCliente,
                                venda.IdColaborador,
                                TotalBruto = venda.TotalBruto.Valor,
                                TotalDesconto = venda.TotalDesconto.Valor,
                                TotalLiquido = venda.TotalLiquido.Valor,
                                LucroTotal = venda.LucroTotal.Valor,
                                venda.FormaDePagamento,
                                venda.DataEmissao,
                            },
                            transaction);

                        venda.Produtos.ForEach(x => x.IdVenda = venda.IdVenda);

                        foreach (var item in venda.Produtos)
                        {
                            conexao.Execute(insertPedidoProduto,
                                new
                                {
                                    item.IdProduto,
                                    PrecoCusto = item.PrecoCusto.Valor,
                                    PrecoVenda = item.PrecoVenda.Valor,
                                    item.IdVenda,
                                    item.Quantidade,
                                    Desconto = item.Desconto.Valor,
                                    PrecoLiquido = item.PrecoLiquido.Valor,
                                    Total = item.Total.Valor,
                                },
                                transaction);
                            conexao.Execute(updateQuantidade, item, transaction);
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        internal void EliminarPedido(VendaModel vendaModel)
        {
            const string updateVenda = @"Update Venda set Status = 0
                                         where IdVenda = @IdVenda";
            const string selectProdutosAntigos = @"Select IdProduto, QuantidadeProduto as Quantidade
                                                   From PedidosProduto
                                                   where IdVenda = @IdVenda";
            const string updateQuantidade = @"Update Produtos set QuantidadeEstoque += @Quantidade
                                                where IdProduto = @IdProduto";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    using (SqlTransaction transaction = conexao.BeginTransaction())
                    {
                        List<CarrinhoModel> produtosAntigos = conexao.Query<CarrinhoModel>(selectProdutosAntigos, new { vendaModel.IdVenda }, transaction).ToList();
                        foreach (var update in produtosAntigos)
                        {
                            conexao.Execute(updateQuantidade, update, transaction);
                        }
                        conexao.Execute(updateVenda, vendaModel, transaction);

                        transaction.Commit();
                    }
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public List<PedidoListaModel> ListarPedidosCadastrados(string nome, bool ativo)
        {
            var selectPedido = @"select  ven.IdVenda, concat(ucli.Nome,' ',ucli.SobreNome) as NomeCliente,
				concat(uco.Nome, ' ', uco.SobreNome) as NomeColaborador,
				 ven.FormaDePagamento, ven.DataEmissao, ven.TotalBruto, ven.TotalDesconto, ven.TotalLiquido, ven.Lucro
				from Venda ven
				inner join Colaboradores as co on ven.IdColaborador = co.IdColaborador
				inner join Clientes as c on ven.IdCliente = c.IdCliente				
				inner join Usuarios ucli on ucli.IdUsuario = c.IdUsuario
				inner join Usuarios uco on uco.IdUsuario = co.IdUsuario
                where ucli.Nome Like @NomeCliente + '%' and ven.Status = @Ativo";
            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query<PedidoListaModel>(
                        selectPedido, new { NomeCliente = nome, Ativo = ativo }
                     ).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public VendaConsulta ExibirPedidoSelecionado(int idVenda)
        {

            const string selectPedido = @"select distinct ven.IdVenda, concat(ucli.Nome,' ',ucli.SobreNome) as NomeCliente,
				concat(uco.Nome, ' ', uco.SobreNome) as NomeColaborador,
                co.IdColaborador, c.IdCliente,
                 ven.FormaDePagamento, ven.TotalBruto, ven.TotalDesconto, ven.TotalLiquido, ven.Lucro, ven.Status as Ativo
				from Venda ven
                inner join PedidosProduto as pp on ven.IdVenda = pp.IdVenda
				inner join Colaboradores as co on ven.IdColaborador = co.IdColaborador
				inner join Clientes as c on ven.IdCliente = c.IdCliente				
				inner join Usuarios ucli on ucli.IdUsuario = c.IdUsuario
				inner join Usuarios uco on uco.IdUsuario = co.IdUsuario
                where ven.IdVenda = @IdVenda";

            const string selectProdutos = @"select pp.IdProduto, p.Nome,
				pp.IdVenda, pp.Desconto, pp.Total, pp.QuantidadeProduto as Quantidade, pp.PrecoVenda, pp.PrecoLiquido,
				pp.PrecoCusto
				from Produtos p
				inner join PedidosProduto as pp on p.IdProduto = pp.IdProduto
                inner join Venda as v on v.idVenda = pp.idVenda
				where v.IdVenda = @IdVenda";
            try
            {
                VendaConsulta venda;
                using (var conexao = ConexaoDao.conectar())
                {
                    venda = conexao.QuerySingle<VendaConsulta>(
                        selectPedido, new { IdVenda = idVenda }
                        );

                    venda.Produtos = conexao.Query<CarrinhoModel>(
                        selectProdutos, new { IdVenda = idVenda }).ToList();
                }

                return venda;
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
        internal void AlterarPedido(VendaModel pedidoModel)
        {
            const string selectProdutosAntigos = @"Select IdProduto, QuantidadeProduto as Quantidade
                                                   From PedidosProduto
                                                   where IdVenda = @IdVenda";

            const string deletePedidoProduto = @"delete PedidosProduto
                                       where IdVenda = @IdVenda;";

            const string updateQuantidade = @"Update Produtos set QuantidadeEstoque += @Quantidade
                                                where IdProduto = @IdProduto";

            const string updateVenda = @"Update Venda set TotalBruto = @TotalBruto, TotalDesconto = @TotalDesconto, 
                                        TotalLiquido = @TotalLiquido, Lucro = @LucroTotal, FormaDePagamento = @FormaDePagamento
                                        where IdVenda = @IdVenda";

            const string insertPedidoProduto = @"Insert into PedidosProduto (IdVenda, PrecoBruto, PrecoCusto, IdProduto, PrecoVenda,
                QuantidadeProduto, Desconto, PrecoLiquido,Total) 
                values (@IdVenda, @PrecoVenda, @PrecoCusto, @IdProduto, @PrecoVenda, @Quantidade, @Desconto, @PrecoLiquido, @Total)
                ";

            const string upQuantidade = @"Update Produtos set QuantidadeEstoque -= @Quantidade 
                                            where IdProduto = @IdProduto";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    using (SqlTransaction transaction = conexao.BeginTransaction())
                    {
                        List<CarrinhoModel> produtosAntigos = conexao.Query<CarrinhoModel>(selectProdutosAntigos, new { pedidoModel.IdVenda }, transaction).ToList();
                        foreach (var item in produtosAntigos)
                        {
                            conexao.Execute(updateQuantidade, item, transaction);
                        }

                        conexao.Execute(deletePedidoProduto, pedidoModel, transaction);

                        conexao.Execute(updateVenda,
                            new
                            {
                                pedidoModel.IdVenda,
                                TotalBruto = pedidoModel.TotalBruto.Valor,
                                TotalDesconto = pedidoModel.TotalDesconto.Valor,
                                TotalLiquido = pedidoModel.TotalLiquido.Valor,
                                LucroTotal = pedidoModel.LucroTotal.Valor,
                                pedidoModel.FormaDePagamento,
                            },
                            transaction);

                        foreach (var item in pedidoModel.Produtos)
                        {
                            conexao.Execute(insertPedidoProduto,
                                new
                                {
                                    item.IdProduto,
                                    PrecoCusto = item.PrecoCusto.Valor,
                                    PrecoVenda = item.PrecoVenda.Valor,
                                    item.IdVenda,
                                    item.Quantidade,
                                    Desconto = item.Desconto.Valor,
                                    PrecoLiquido = item.PrecoLiquido.Valor,
                                    Total = item.Total.Valor,
                                },
                                transaction);
                            conexao.Execute(upQuantidade, item, transaction);
                        }

                        transaction.Commit();
                    }
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
