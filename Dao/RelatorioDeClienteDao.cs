using CrudAugustusFashion.Model.RelatorioCliente;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    class RelatorioDeClienteDao
    {
        internal IList<RelatorioClienteModel> ListarRelatorioPeloFiltro(FiltroRelatorioCliente filtros)
        {
            var Conteudo = @"c.IdCliente, u.Nome, count(v.IdVenda) as QuantidadeVendas, sum(v.TotalBruto) as TotalBruto, 
                        SUM(v.TotalDesconto) as TotalDesconto, sum(v.TotalLiquido) as TotalLiquido
                        from Clientes c 
                        inner join Venda v on v.IdCliente = c.IdCliente
                        inner join Usuarios u on u.IdUsuario = c.IdUsuario";
            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query<RelatorioClienteModel>(Conteudo += filtros.GeradorDeSql(), filtros.RecuperarParametros()).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
