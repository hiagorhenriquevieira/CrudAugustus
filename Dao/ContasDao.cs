using CrudAugustusFashion.Model.ContasAReceberModel;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    public class ContasDao
    {
        internal List<ListaDeContasAReceberModel> ListarComprasAPrazo(string text, bool ativo)
        {
            const string selectPedido = @"select v.IdVenda, Concat (u.Nome, ' ', u.SobreNome) as NomeCompleto ,v.TotalLiquido as ValorAPagar , v.FormaDePagamento,
                                            v.DataEmissao, cr.Ativo, cr.DataPagamento
                                            from venda v
                                            inner join Clientes c on v.IdCliente = c.IdCliente
                                            inner join Usuarios u on c.IdUsuario = u.IdUsuario
                                            inner join ContasAReceber cr on v.IdVenda = cr.IdVenda
                                            where u.Nome like @Nome + '%' and cr.ativo = @Ativo;";

            using (var conexao = ConexaoDao.conectar())
            {
                return conexao.Query<ListaDeContasAReceberModel>(selectPedido, new { Nome = text, ativo }).ToList();
            }
        }
        internal void PagarContaAPrazo(int idVenda)
        {
            const string update = @"Update ContasAReceber set Ativo = 0, DataPagamento = @dataPagamento
                                     where IdVenda = @IdVenda";

            using (var conexao = ConexaoDao.conectar())
                try
                {
                    conexao.Query(update, new { IdVenda = idVenda, dataPagamento = DateTime.Now }).ToString();      
                }
                catch (Exception excecao)
                {
                    throw new Exception(excecao.Message);
                }
        }
    }
}
