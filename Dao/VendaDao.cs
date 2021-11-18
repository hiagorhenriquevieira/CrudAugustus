using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace CrudAugustusFashion.Dao
{
    public class VendaDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public void CadastrarVendaPedido()
        {
            const string insertPedido = @"Insert into Pedidos (TotalBruto, TotalDesconto, TotalLiquido)  
                output inserted.IdPedido 
                values ( @TotalBruto, @TotalDesconto, @TotalLiquido)";

            const string insertVenda = @"Insert into Venda (IdProduto, IdCliente, IdColaborador, PrecoBruto, PrecoCusto
                QuantidadeProduto, Desconto, PrecoLiquido, Total) values (@IdProduto, @IdCliente, @IdColaborador, @PrecoBruto, @PrecoCusto
                @QuantidadeProduto, @Desconto, @PrecoLiquido, @Total)";

            const string insertFormaPagamento = @"Insert into FormaDePagamento (IdVenda) values (@IdVenda)";

            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    conexao.Open();
                    using (SqlTransaction transaction = conexao.BeginTransaction())
                    {
                        //pedido.IdPedido = sqlCon.ExecuteScalar<int>(insertPedido, pedido, transaction);

                        //pedido.Produtos.ForEach(x => x.IdPedido = pedido.IdPedido);

                        //sqlCon.Execute(strSqlPedidoProduto, pedido.Produtos, transaction);

                        //transaction.Commit();
                    }
                }
            }catch
            {

            }
        }
    } 
}
//var strSqlPedido = @"Insert into Pedidos (IdCliente, IdColaborador, FormaPagamento, DataEmissao, TotalBruto, TotalDesconto, TotalLiquido)  
//                output inserted.IdPedido 
//                values (@IdCliente, @IdColaborador, @FormaPagamento, @DataEmissao, @TotalBruto, @TotalDesconto, @TotalLiquido)";

//var strSqlPedidoProduto = @"insert into Pedido_Produto (IdPedido, IdProduto, PrecoVenda, Quantidade, Desconto, PrecoLiquido, Total)
//                values (@IdPedido, @IdProduto, @PrecoVenda, @Quantidade, @Desconto, @PrecoLiquido, @Total) ";