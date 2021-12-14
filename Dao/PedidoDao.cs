using CrudAugustusFashion.Model.Produto;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    class PedidoDao
    {
        public List<ProdutoLista> BuscarProdutoParaVenda(string nome)
        {
            const string selectProduto = @"Select IdProduto, CodigoDeBarras, Nome, Fabricante, PrecoCusto, PrecoVenda, QuantidadeEstoque
                                           from Produtos
                                           where Nome Like @Nome + '%' and Status = 1";
            using (var conexao = ConexaoDao.conectar())
            {
                return conexao.Query<ProdutoLista>(selectProduto, new { Nome = nome }).ToList();
            }
        }
    }
}
