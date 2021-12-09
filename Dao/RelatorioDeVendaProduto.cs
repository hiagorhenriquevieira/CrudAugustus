using CrudAugustusFashion.Model.RelatorioVendaProduto;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    public class RelatorioDeVendaProduto
    {
        public List<RelatorioVendaProdutoModel> ListarRelatorioPeloFiltro(FiltroRelatorioVendaProdutoModel filtro)
        {
            var SelectRelatorio = @"Select p.IdProduto ,p.Nome, sum(pp.QuantidadeProduto) as Quantidade, sum(pp.PrecoVenda * pp.QuantidadeProduto) as TotalBruto, 
                                    SUM(pp.Desconto * pp.QuantidadeProduto)as Desconto, sum(pp.PrecoLiquido * pp.QuantidadeProduto) as TotalLiquido, 
                                    sum(pp.PrecoCusto * pp.QuantidadeProduto)as TotalCusto,
                                    sum(pp.QuantidadeProduto * pp.PrecoLiquido) - sum(pp.QuantidadeProduto * pp.PrecoCusto) as LucroReais,
                                    (sum(pp.QuantidadeProduto * pp.PrecoLiquido) - sum(pp.QuantidadeProduto * pp.PrecoCusto))/sum(pp.PrecoCusto * pp.QuantidadeProduto)*100 as LucroPorcentagem
                                    from PedidosProduto pp 
                                    inner join Produtos p on pp.IdProduto = p.IdProduto
                                    inner join Venda v on pp.IdVenda = v.IdVenda ";


            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query<RelatorioVendaProdutoModel>(SelectRelatorio += filtro.GerarSql(), filtro.RecuperarParametros()).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
