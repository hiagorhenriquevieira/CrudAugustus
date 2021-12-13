using CrudAugustusFashion.Enums;
using Dapper;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CrudAugustusFashion.Model.RelatorioCliente
{
    public class FiltroRelatorioCliente
    {

        public int IdCliente { get; set; }
        public decimal ValorMinimo { get; set; }
        public EFiltrarPor FiltrarPor { get; set; }
        public int LimiteClientes { get; set; }
        public EOrdenarPor OrdenarPor { get; set; }
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

            if (ValorMinimo != 0) GroupBy += $" Having sum({GetEnumDescription(FiltrarPor)}) > @ValorMinimo ";

            if (LimiteClientes != 0) select += " top  " + LimiteClientes;

            GroupBy += GerarOrderBy(); 
        


            return select + Conteudo + Where + GroupBy;
    }

        public static string GetEnumDescription<T>(T value) where T : Enum
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
        

        public string GerarOrderBy()
        {
            var orderBy = GetEnumDescription(OrdenarPor);
            if (Ordem == 1)
            {
                orderBy += " desc ";
            }
            return orderBy;
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
