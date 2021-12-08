using Dapper;
using System;

namespace CrudAugustusFashion.Model.RelatorioCliente
{
    public class FiltroRelatorioCliente
    {

        public int IdCliente { get; set; }
        public decimal ValorMinimo { get; set; }
        public int LimiteClientes { get; set; }
        public int OrdenarPor { get; set; }
        public int Ordem{ get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataFinal { get; set; }


    public string GeradorDeSql()
    {
            var select = @" Select ";

            var Conteudo = @"c.IdCliente, u.Nome, count(v.IdVenda) as QuantidadeVendas, sum(v.TotalBruto) as TotalBruto, 
                        SUM(v.TotalDesconto) as TotalDesconto, sum(v.TotalLiquido) as TotalLiquido
                        from Clientes c 
                        inner join Venda v on v.IdCliente = c.IdCliente
                        inner join Usuarios u on u.IdUsuario = c.IdUsuario";

            var Where = @" where v.DataEmissao BETWEEN @DataEmissao and @DataFinal  ";

            var GroupBy = " Group BY c.IdCliente, u.Nome ";

            if (IdCliente != 0) Where += " and v.IdCliente = @IdCliente ";

            if (ValorMinimo != 0) GroupBy += " Having sum(v.TotalLiquido) > @ValorMinimo ";

            if (LimiteClientes != 0) select += " top  " + LimiteClientes;

            GroupBy += GerarOrderBy(); 
        


            return select + Conteudo + Where + GroupBy;
    }
       
        private string GerarOrderBy()
        {
            if (OrdenarPor == 2 && Ordem == 1)
                return " Order by TotalLiquido desc ";

            if (OrdenarPor == 2 && Ordem == 0)
                return " Order by TotalLiquido asc ";

            if (OrdenarPor == 0 && Ordem == 1)
                return " Order by QuantidadeVendas desc ";
            if (OrdenarPor == 0 && Ordem == 0)
                return " Order by QuantidadeVendas asc ";


            if (OrdenarPor == 1 && Ordem == 1)
                return " Order by Desconto desc ";
            if (OrdenarPor == 1 && Ordem == 0)
                return " Order by Desconto asc ";

            return "";
        }


    public DynamicParameters RecuperarParametros()
    {
        var parameters = new DynamicParameters();

        parameters.AddDynamicParams(
            new
            {
                
                IdCliente,
                ValorMinimo,
                LimiteClientes,
                OrdenarPor,
                Ordem,
                DataEmissao,
                DataFinal,
            }
            );

        return parameters;
    }


    }



}
