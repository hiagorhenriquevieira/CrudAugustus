using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Cliente;
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
        //ConexaoDao conexao = new ConexaoDao();
        public void CadastrarVendaPedido(VendaModel venda)
        { 
            const string insertVenda = @"Insert into Venda (IdCliente, IdColaborador, TotalBruto, TotalDesconto, TotalLiquido, Lucro, FormaDePagamento)  
                output inserted.IdVenda 
                values (@IdCliente, @IdColaborador, @TotalBruto, @TotalDesconto, @TotalLiquido, @LucroTotal, @FormaDePagamento)";

            const string insertPedido = @"Insert into PedidosProduto (IdVenda, PrecoBruto, PrecoCusto,
                QuantidadeProduto, Desconto, PrecoLiquido,Total) 
                values (@IdVenda, @PrecoVenda, @PrecoCusto, @Quantidade, @DescontoDecimal, @PrecoLiquido, @Total)";
            const string updateQuantidade = @"Update  Produtos set QuantidadeEstoque -= @Quantidade 
                                            where IdProduto = @IdProduto";
            

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    using (SqlTransaction transaction = conexao.BeginTransaction())
                    {
                        venda.IdVenda = conexao.ExecuteScalar<int>(insertVenda, venda, transaction);

                        venda.Produtos.ForEach(x => x.IdVenda = venda.IdVenda);

                        conexao.Execute(insertPedido, venda.Produtos, transaction);
                        foreach (var update in venda.Produtos)
                        {
                            conexao.Execute(updateQuantidade, update, transaction);
                        }
                        transaction.Commit();
                    }
                }
            }catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
        public List<PedidoListaModel> ListarPedidosCadastrados()
        {
            var selectPedido = @"select  ven.IdVenda, concat(ucli.Nome,' ',ucli.SobreNome) as NomeCliente,
				concat(uco.Nome, ' ', uco.SobreNome) as NomeColaborador,
				 ven.FormaDePagamento, ven.TotalBruto, ven.TotalDesconto, ven.TotalLiquido, ven.Lucro
				from Venda ven
				inner join Colaboradores as co on ven.IdColaborador = co.IdColaborador
				inner join Clientes as c on ven.IdCliente = c.IdCliente				
				inner join Usuarios ucli on ucli.IdUsuario = c.IdUsuario
				inner join Usuarios uco on uco.IdUsuario = co.IdUsuario";
            try
            {
                using (var conexao  = ConexaoDao.conectar())
                {
                    return conexao.Query<PedidoListaModel>(
                        selectPedido
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
                 ven.FormaDePagamento, ven.TotalBruto, ven.TotalDesconto, ven.TotalLiquido, ven.Lucro
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
                using ( var conexao = ConexaoDao.conectar())
                {
                    venda = conexao.QuerySingle<VendaConsulta>(
                        selectPedido, new {IdVenda = idVenda}
                        );

                    venda.Produtos = conexao.Query<CarrinhoModel>(
                        selectProdutos, new {IdVenda = idVenda}).ToList();
                }
                
                return venda;
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
        public int RecuperarIdUsuario(int IdCliente)
        {
            var SelectIdCliente = @"select concat (Nome, ' ', SobreNome) as NomeCompleto from Clientes 
                                    where IdCliente = @IdCliente;";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.QuerySingle<int>(SelectIdCliente, new { IdCliente });
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
        public string RecuperarNomeCliente( int idCliente)
        {
            var nomeCliente = RecuperarIdUsuario(idCliente);
            const string selectCliente = @"select 
                            c.IdUsuario, concat (u.Nome, ' ' ,u.SobreNome) as NomeCompleto
                            from
                            Usuarios u inner join Clientes c on u.IdUsuario = c.IdUsuario
                            where c.IdUsuario = @IdUsuario;";

            try
            
            
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query<string>(selectCliente, new {nomeCliente}).FirstOrDefault();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    } 
}
