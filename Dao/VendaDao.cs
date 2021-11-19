using Dapper;
using System;
using System.Data.SqlClient;
using VendaModel = CrudAugustusFashion.Model.Pedido.VendaModel;

namespace CrudAugustusFashion.Dao
{
    public class VendaDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public void CadastrarVendaPedido(VendaModel venda)
        {
            const string insertVenda = @"Insert into Venda (IdCliente, IdColaborador, TotalBruto, TotalDesconto, TotalLiquido, Lucro)  
                output inserted.IdVenda 
                values (@IdCliente, @IdColaborador, @TotalBruto, @TotalDesconto, @TotalLiquido, @Lucro)";

            const string insertPedido = @"Insert into PedidosProduto (IdVenda, PrecoBruto, PrecoCusto,
                QuantidadeProduto, Desconto, PrecoLiquido, Total) 
                values (@IdVenda, @PrecoVenda, @PrecoCusto, @Quantidade, @DescontoDecimal, @PrecoLiquido, @Total)";

            //const string insertFormaPagamento = @"Insert into FormaDePagamento (IdVenda) values (@IdVenda)";

            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    using (SqlTransaction transaction = conexao.BeginTransaction())
                    {
                        venda.IdVenda = conexao.ExecuteScalar<int>(insertVenda, venda, transaction);

                        venda.Produtos.ForEach(x => x.IdVenda = venda.IdVenda);

                        conexao.Execute(insertPedido, venda.Produtos, transaction);

                        //pedido.IdPedido = conexao.Execute(insertFormaPagamento, transaction);

                        transaction.Commit();
                    }
                }
            }catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    } 
}
//var strSqlPedido = @"Insert into Pedidos (IdCliente, IdColaborador, FormaPagamento, DataEmissao, TotalBruto, TotalDesconto, TotalLiquido)  
//                output inserted.IdPedido 
//                values (@IdCliente, @IdColaborador, @FormaPagamento, @DataEmissao, @TotalBruto, @TotalDesconto, @TotalLiquido)";

//var strSqlPedidoProduto = @"insert into Pedido_Produto (IdPedido, IdProduto, PrecoVenda, Quantidade, Desconto, PrecoLiquido, Total)
//                values (@IdPedido, @IdProduto, @PrecoVenda, @Quantidade, @Desconto, @PrecoLiquido, @Total) ";