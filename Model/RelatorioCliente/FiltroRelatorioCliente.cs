using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model.RelatorioCliente
{
    public class FiltroRelatorioCliente
    {

        public int IdCliente { get; set; }
        public decimal ValorMinimo { get; set; }
        public int LimiteClientes { get; set; }
        public string OrdenarPor { get; set; }
        public string Ordem{ get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataFinal { get; set; }


    public string GeradorDeSql()
    {
        var select = @" Select ";   

        var Conteudo = @" u.Nome, count(v.IdVenda) as QuantidadeVendas,sum(pp.PrecoVenda * pp.QuantidadeProduto) as TotalBruto, 
                        SUM(pp.Desconto * pp.QuantidadeProduto) as Desconto, sum(pp.PrecoLiquido * pp.QuantidadeProduto) as TotalLiquido
                        from Clientes c 
                        inner join Venda v on v.IdCliente = c.IdCliente
                        inner join PedidosProduto pp on pp.IdVenda = v.IdVenda
                        inner join Usuarios u on u.IdUsuario = c.IdUsuario ";

        var Where = @" where v.DataEmissao BETWEEN @DataEmissao and @DataFinal
                       and v.status = 1 ";

        var GroupBy = " Group BY u.Nome ";

            if (IdCliente != 0) Where += " and v.IdCliente = @IdCliente ";
        
        if(ValorMinimo != 0) GroupBy += " Having sum(pp.PrecoLiquido * pp.QuantidadeProduto) > @ValorMinimo ";

        if (LimiteClientes != 0) select += " top  " + LimiteClientes;

        if (OrdenarPor == "Total Liquido" && Ordem == "Decrescente") GroupBy += " Order by TotalLiquido desc ";
        if (OrdenarPor == "Total Liquido" && Ordem == "Crescente") GroupBy += " Order by TotalLiquido asc ";
        if (OrdenarPor == "Total Liquido" && Ordem == "") GroupBy += " Order by TotalLiquido ";
        

        if (OrdenarPor == "Quantidade" && Ordem == "Decrescente") GroupBy += " Order by QuantidadeVendas desc ";
        if (OrdenarPor == "Quantidade" && Ordem == "Crescente") GroupBy += " Order by QuantidadeVendas asc ";
        if (OrdenarPor == "Quantidade" && Ordem == "") GroupBy += " Order by QuantidadeVendas ";

        if (OrdenarPor == "Total Desconto" && Ordem == "Decrescente") GroupBy += " Order by Desconto desc ";
        if (OrdenarPor == "Total Desconto" && Ordem == "Crescente") GroupBy += " Order by Desconto asc ";
        if (OrdenarPor == "Total Desconto" && Ordem == "") GroupBy += " Order by Desconto ";


            return select + Conteudo + Where + GroupBy;
        
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
