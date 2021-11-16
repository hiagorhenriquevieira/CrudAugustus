using CrudAugustusFashion.Model.Produto;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Dao
{
    class PedidoDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public List<ProdutoLista> BuscarProdutoParaVenda(string nome)
        {
            const string selectProduto = @"Select IdProduto, CodigoDeBarras, Nome, Fabricante, PrecoCusto, PrecoVenda
                                           from Produtos
                                           where Nome Like @Nome + '%' and Status = 1";
            using (var conexao = this.conexao.conectar())
            {
                return conexao.Query<ProdutoLista>(selectProduto, new { Nome = nome }).ToList();
            }
        }
    }
}
