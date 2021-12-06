using CrudAugustusFashion.Model.RelatorioVendaProduto;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    public class RelatorioDeVendaProduto
    {
        public IList<RelatorioVendaProdutoModel> ListarRelatorioPeloFiltro(FiltroRelatorioVendaProdutoModel filtro)
        {
            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query<RelatorioVendaProdutoModel>(filtro.GerarSql(), filtro.RecuperarParametros()).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
