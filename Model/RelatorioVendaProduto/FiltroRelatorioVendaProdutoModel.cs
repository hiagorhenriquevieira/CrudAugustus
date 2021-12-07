using Dapper;
using System;

namespace CrudAugustusFashion.Model.RelatorioVendaProduto
{
    public class FiltroRelatorioVendaProdutoModel
    {
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataFinal { get; set; }
        public string Nome { get; set; }



        public string GerarSql()
        {
            var SelectRelatorio = @"Select p.IdProduto ,p.Nome, sum(pp.QuantidadeProduto) as Quantidade, sum(pp.PrecoVenda * pp.QuantidadeProduto) as TotalBruto, 
                                    SUM(pp.Desconto * pp.QuantidadeProduto)as Desconto, sum(pp.PrecoLiquido * pp.QuantidadeProduto) as TotalLiquido, 
                                    sum(pp.PrecoCusto * pp.QuantidadeProduto)as TotalCusto,
                                    sum(pp.QuantidadeProduto * pp.PrecoLiquido) - sum(pp.QuantidadeProduto * pp.PrecoCusto) as LucroReais,
                                    (sum(pp.QuantidadeProduto * pp.PrecoLiquido) - sum(pp.QuantidadeProduto * pp.PrecoCusto))/sum(pp.PrecoCusto * pp.QuantidadeProduto)*100 as LucroPorcentagem
                                    from PedidosProduto pp 
                                    inner join Produtos p on pp.IdProduto = p.IdProduto
                                    inner join Venda v on pp.IdVenda = v.IdVenda ";

            var GroupBy = "GROUP BY p.IdProduto, p.Nome ";

            var Where = " where v.DataEmissao BETWEEN @DataEmissao and @DataFinal ";

            if (IdCliente != 0) Where += " and v.IdCliente = @IdCliente ";

            if (IdProduto != 0) Where += " and p.IdProduto = @IdProduto ";

            return SelectRelatorio + Where + GroupBy;


        }
        
        public DynamicParameters RecuperarParametros()
        {
            var parameters = new DynamicParameters();

            parameters.AddDynamicParams(
                new
                {
                    Nome,
                    IdCliente,
                    IdProduto,
                    DataEmissao,
                    DataFinal,
                }
                );

            return parameters;
        }
    }
}
