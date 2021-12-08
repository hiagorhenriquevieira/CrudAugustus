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
            var GroupBy = "GROUP BY p.IdProduto, p.Nome ";

            var Where = " where v.DataEmissao BETWEEN @DataEmissao and @DataFinal ";

            if (IdCliente != 0) Where += " and v.IdCliente = @IdCliente ";

            if (IdProduto != 0) Where += " and p.IdProduto = @IdProduto ";

            return Where + GroupBy;
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
