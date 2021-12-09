using CrudAugustusFashion.Model.RelatorioCliente;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    class RelatorioDeClienteDao
    {
        internal List<RelatorioClienteModel> ListarRelatorioPeloFiltro(FiltroRelatorioCliente filtros)
        {
            
            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query<RelatorioClienteModel>(filtros.GeradorDeSql(), filtros.RecuperarParametros()).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
