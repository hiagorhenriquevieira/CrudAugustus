﻿using CrudAugustusFashion.Model.RelatorioCliente;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Dao
{
    class RelatorioDeClienteDao
    {
        internal IList<RelatorioClienteModel> ListarRelatorioPeloFiltro(FiltroRelatorioCliente filtros)
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
